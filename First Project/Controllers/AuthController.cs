using First_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace First_Project.Controllers
{
    public class AuthController : Controller
    {
        private readonly ModelContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public AuthController(ModelContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult login ([Bind(" Username , Password ")] Login userlogin)
        {
            var account = _context.Logins.Where(x => x.Username == userlogin.Username && x.Password == userlogin.Password).SingleOrDefault();
            
            if(account!=null)
            {
                switch(account.RoleId)
                { //admin
                    case 1:
                        HttpContext.Session.SetInt32("AdminId", (int)account.UserId);
                        return RedirectToAction("Index","Admin");
                    //user
                    case 2:
                        HttpContext.Session.SetInt32("UserId", (int)account.UserId);
                        return RedirectToAction("Index", "user");
                }
            }
            else
            {
                ModelState.AddModelError("username", "Your username or password is incorrect");

            }
            return View();
        }

        


        public IActionResult register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> register([Bind("Id,FullName,Email,Address,City,Birthdate,ImagePath,PhoneNumber,ImageFile")] User user, string username, string password,string currentPassword)
        {

            if (user.ImageFile != null)
            {
                string wwwRootPath = _webHostEnviroment.WebRootPath;
                string fileName = Guid.NewGuid().ToString() + "_" + user.ImageFile.FileName;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await user.ImageFile.CopyToAsync(fileStream);
                }
                user.ImagePath = fileName;

            }
            else
            {
                user.ImagePath = "defalut.jpg";

            }
            var emailCheck = _context.Users.Where(x => x.Email == user.Email).FirstOrDefault();
            if (emailCheck != null)
            {
                ModelState.AddModelError("Email", "Email has already been taken");

            }
            else {
                var userCheck = _context.Logins.Where(x => x.Username == username).FirstOrDefault();
                if (userCheck != null)
                {
                    ModelState.AddModelError("username", "Username has already been taken");

                }
                else if (password != currentPassword) {
                    ModelState.AddModelError("password", "The password confirmation does not match");

                }
                else { 
            _context.Add(user);
            await _context.SaveChangesAsync();


            Login userlogin = new Login();
            userlogin.Username = username;
            userlogin.Password = password;
            userlogin.UserId = user.Id;
            userlogin.RoleId = 2;
            _context.Add(userlogin);
            await _context.SaveChangesAsync();
                    ModelState.AddModelError("success", "Welcome,your account has been createn");

                }
             }
            return View();


            }

        }
}
