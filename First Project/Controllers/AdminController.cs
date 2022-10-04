using First_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;



namespace First_Project.Controllers
{
    public class AdminController : Controller
    {
        private readonly ModelContext _context;

        private readonly IWebHostEnvironment _hostEnvironment;

        public AdminController(ModelContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _hostEnvironment = webHostEnviroment;
        }


        public IActionResult Index()
        {
            ViewBag.users = _context.Users.Count();
            ViewBag.total = _context.Orders.Sum(x => x.Amount);
            var orders = _context.Orders.ToList();
            var orderproduct = _context.OrderProducts.ToList();
            var store = _context.Stores.ToList();
            var product = _context.Products.ToList();

            var total = from o in orders
                        join op in orderproduct on o.Id equals op.OrderId
                        join p in product on op.ProductId equals p.Id
                        join s in store on p.StoreId equals s.Id
                        group op by s.Name into n
                        select new TotalOrders
                        {
                            storeName = n.Key,
                            Summ = n.Sum(x => x.Quantity*x.Product.Price)
                        };

            return View(total);

        }

        public IActionResult widgets()
        {
            return View();
        }

        public IActionResult tables()
        {
            return View();
        }

        public IActionResult forms()
        {
            return View();
        }
        public IActionResult charts()
        {
            return View();
        }

        public IActionResult buttons()
        {
            return View();
        }

        public IActionResult element()
        {
            return View();
        }

        public IActionResult typography()
        {
            return View();
        }

        public IActionResult blank()
        {
            return View();
        }

        public IActionResult error()
        {
            return View();
        }

        public IActionResult signup()
        {
            return View();
        }

        public IActionResult signin()
        {
            return View();
        }
        public IActionResult settings()
        {
/*            var total = _context.Users.Where(x => x.Id == Admind).Include(x => x.Logins.Where(x => x.Id == Admind).SingleOrDefault());
*/
            int Admind = (int)HttpContext.Session.GetInt32("AdminId");
            var user = _context.Users.Where(x => x.Id == Admind).SingleOrDefault();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> settings([Bind("Id,FullName,Email,Address,City,Birthdate,ImageFile,ImagePath,PhoneNumber")] User user)
        {

            if (ModelState.IsValid)
            {
               if (user.ImageFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" + user.ImageFile.FileName;
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await user.ImageFile.CopyToAsync(fileStream);
                    }
                    user.ImagePath = fileName;
                }
      

                _context.Update(user);
                await _context.SaveChangesAsync();


            }
            return RedirectToAction("settings", "Admin");
        }

        public IActionResult LoginSettings()
        {

            int userId = (int)HttpContext.Session.GetInt32("UserId");
            var userLogin = _context.Logins.Where(x => x.UserId == userId).SingleOrDefault();

            return View(userLogin);
        }

        [HttpPost]
        public  IActionResult LoginSettings(string UserName, string NewUserName ,string CurrentPassword,string Password)
        {
            int Admind = (int)HttpContext.Session.GetInt32("AdminId");
            var userLogin = _context.Logins.Where(x => x.UserId == Admind).SingleOrDefault();
            if(userLogin !=null)
            {
                if (_context.Logins.Where(x => x.Username == NewUserName).SingleOrDefault() != null)
                {
                    ModelState.AddModelError("NewUserName", "Username already exists");
                }
                else if (userLogin.Password != CurrentPassword && CurrentPassword!=null)
                 {
                    ModelState.AddModelError("CurrentPassword", "Your current password is wrong");
                }
                else {
                    if (Password != null)
                    {
                        userLogin.Password = Password;
                    }
                    if(NewUserName!=null)
                    {
                        userLogin.Username = NewUserName;

                    }

                }

            }

            _context.Logins.Update(userLogin);
             _context.SaveChangesAsync();

            return RedirectToAction("LoginSettings", "Admin");
        }




        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Search()
        {
            var modelContext = _context.OrderProducts.Include(p => p.Order).Include(p => p.Product).ToList();
            return View(modelContext);

        }

        [HttpPost]
        public IActionResult search(DateTime? startDate, DateTime? endDate)
        {

            var modelContext = _context.OrderProducts.Include(p => p.Order).Include(p => p.Product).ToList();

            if (startDate == null && endDate == null)
            {
                return View(modelContext);
            }
            else if (startDate != null && endDate == null)
            {
                var result = modelContext.Where(x => x.Order.OrderDate.Value.Date == startDate);
                return View(result);
            }
            else if (startDate == null && endDate != null)
            {
                var result = modelContext.Where(x => x.Order.OrderDate.Value.Date == endDate);
                return View(result);
            }
            else if(startDate != null && endDate != null)
            {
                
                    var result = modelContext.Where(x => x.Order.OrderDate.Value.Date >= startDate && x.Order.OrderDate.Value.Date <= endDate);
                    return View(result);
                
            }
            return View();
        }
        



        

    }
}
