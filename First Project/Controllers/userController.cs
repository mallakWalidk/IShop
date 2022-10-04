using First_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rotativa;

namespace First_Project.Controllers
{
    

    public class userController : Controller
    {
        private readonly ILogger<userController> _logger;
        private readonly ModelContext _context;

        private readonly IWebHostEnvironment _hostEnvironment;

             public userController(ILogger<userController> logger,ModelContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _logger = logger;
            _hostEnvironment = webHostEnviroment;

        }

        public IActionResult Index()
        {if (ViewBag.UserId = HttpContext.Session.GetInt32("UserId") != null)
            {
                ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
                int user_id = (int)HttpContext.Session.GetInt32("UserId");

                var name = _context.Users.Where(x => x.Id == user_id).FirstOrDefault();
                ViewBag.Fname = name.FullName;
                ViewBag.Email = name.Email;
                ViewBag.ImagePath = name.ImagePath;
                HttpContext.Session.SetString("ImagePath", name.ImagePath);
                HttpContext.Session.SetString("Fname", name.FullName);

                var home = _context.Homes.Where(x => x.Id == 1).FirstOrDefault();
                ViewBag.FirstDisc = home.FirstDescreption;
                ViewBag.SecondDisc = home.SecondDescreption;
                ViewBag.FirstImg = home.FirstImgPath;
                ViewBag.SecondImg = home.SecondImgPath;

            }
            return View();
        }

       
        public IActionResult about()
        {
            var home = _context.Homes.Where(x => x.Id == 1).FirstOrDefault();
            ViewBag.Name = home.SecondDescreption;

            var about=_context.AboutUs.Where(x => x.Id == 1).FirstOrDefault();
            ViewBag.FirstDisc = about.FirstDescreption;
            ViewBag.SecondDisc = about.SecondDescreption;
            ViewBag.Img = about.ImgPath;

            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            return View();
        }
        public IActionResult contact()
        {
            var contact = _context.ContactUs.Where(x => x.Id == 1).FirstOrDefault();
            ViewBag.facebook=contact.Facebook;
            ViewBag.email=contact.Email;
            ViewBag.instagram = contact.Instagram;
            ViewBag.phone = contact.Phonenumber;
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            return View();

        }
        public IActionResult testimonial()
        {
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");
            var customer = _context.Testimonials.Where(x => x.State == true).Include(s=>s.User);
            ViewBag.UserID = HttpContext.Session.GetInt32("UserId");

            return View(customer);

        }

        [HttpPost]
        public IActionResult testimonial(string text,int id)
        {
            Testimonial feedback = new Testimonial();
            feedback.UserId = id;
            feedback.Text = text;
            feedback.State = false;
            feedback.PostTime= DateTime.Now;
            _context.Testimonials.Add(feedback);
            _context.SaveChanges();
            return RedirectToAction("testimonial");
        }

        public IActionResult cart()
        {
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
           int userId = (int)HttpContext.Session.GetInt32("UserId");

            var modelContext = _context.OrderProducts.Include(s => s.Product).Include(s => s.Order);
            var Orders = _context.Orders.Where(x => x.UserId == (HttpContext.Session.GetInt32("UserId")) && x.State=="0").FirstOrDefault();

            ViewBag.Amount = 0;
            if (Orders == null || Orders.State == "1")
            {

                var newOrder = new Order();
                newOrder.UserId = userId;
                _context.Add(newOrder);
                _context.SaveChangesAsync();

            }
            else {
                foreach (var item in modelContext)
                {
                    if (item.OrderId == Orders.Id)
                    {
                        ViewBag.Amount = ViewBag.Amount + item.Product.Price * item.Quantity;
                    }


                }
                 Orders = _context.Orders.Where(x => x.UserId == (HttpContext.Session.GetInt32("UserId")) && x.State == "0").FirstOrDefault();
                ViewBag.OrderId = Orders.Id;
                Orders.Amount = ViewBag.Amount;
            _context.Update(Orders);
            _context.SaveChangesAsync();
                }
                ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            return View(modelContext);
        }

        public IActionResult store(int Id)
        {
            var stores = _context.Stores.Where(x => x.CategoryId == Id);
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            return View(stores);

        }

        public IActionResult category()
        {
            var cat = _context.Categories.ToList();
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            return View(cat);

        }

      

        public IActionResult delete(int id)
        {
            var product = _context.OrderProducts.Where(x => x.Id == id).FirstOrDefault();
            _context.OrderProducts.Remove(product);
            _context.SaveChanges();
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            return RedirectToAction("cart");

        }

        public IActionResult products(int Id)
        {
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            var products = _context.Products.Where(x => x.StoreId == Id).Include(x => x.Category);

            return View(products);

        }

        public IActionResult product(int Id)
        {
            var product = _context.Products.Where(x => x.Id == Id);
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            return View(product);

        }

        [HttpPost]
        public async Task<IActionResult> cartAsync(string cardExp,string cardNumber, string cardName, int cardCvv,int amount,int id)
        {

            var card = _context.CreditCards.Where(x => x.SerialNumber == cardNumber).FirstOrDefault();
            if (card!=null)
            {
                var exp = card.ExpMonth + "/" + card.ExpYear;

                if ((card.CustomerName==cardName && cardExp== exp && card.Cvv==cardCvv))
                  {
                      if (card.Balance < amount)
                      {
                          ModelState.AddModelError("amount", "Your balance is not enough");
                        return View("cart");

                      }
                      else
                      {
                         var currentOrder = _context.Orders.Where(x => x.Id == id && x.State=="0").FirstOrDefault();
                          var orderProducts = _context.OrderProducts.Where(x => x.OrderId == id);
                          currentOrder.OrderDate = DateTime.Now;
                          currentOrder.State = "1";
                        card.Balance = card.Balance - amount;
                        _context.Orders.Update(currentOrder);
                          foreach(var item in orderProducts)
                          {
                              item.State = "1";
                              _context.OrderProducts.Update(item);

                        }
                        _context.SaveChanges();


                    }
                }
                  else
                  {
                      ModelState.AddModelError("card", "Your card information is incorrect");
                    return View("cart");

                  }
                
              }
            else
            {
                ModelState.AddModelError("card", "Your card information is incorrect");
                return View("cart");

            }
            /*
                        FileStream fs = new FileStream("invoice.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();
                        doc.Add(new Paragraph("Hello World"));
                        doc.Close();*/



            var orderCurrent = _context.Orders.Where(x => x.Id == id).Include(x => x.User).FirstOrDefault();
            var body = "<p>IShop invoice</p> <p>Customer Name: {0} </p> Date: {1}  <p>Total Amount:  {2}</p> <p>Thank you for shopping </p> ";
                var message = new MailMessage();
                message.To.Add(new MailAddress("mallakwalidkh@hotmail.com"));  // replace with valid value 
                message.From = new MailAddress("IShop2022@outlook.com");  // replace with valid value
                message.Subject = "Invoice";
                message.Body = string.Format(body,orderCurrent.User.FullName, DateTime.Now, orderCurrent.Amount);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "IShop2022@outlook.com",  // replace with valid value
                        Password = "11223344Is"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                }

            return RedirectToAction("invoice", "user", orderCurrent);
        }

        public IActionResult invoice(Order order1)
        {
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            var total = _context.OrderProducts.Where(x => x.OrderId == order1.Id).Include(x => x.Order).Include(x => x.Product);
            var user = _context.Users.Where(x => x.Id == order1.UserId).FirstOrDefault();
            var Uorder=_context.Orders.Where(x=>x.Id== order1.Id).FirstOrDefault();
            ViewBag.Total = Uorder.Amount;
            ViewBag.User = user.FullName;
            return View(total);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult product(int ProductId,int Quantity)
        {
            var product = _context.Products.Where(x => x.Id == ProductId).FirstOrDefault();
            var userId=HttpContext.Session.GetInt32("UserId");
            var Orders = _context.Orders.Where(x => x.UserId == userId && x.State=="0").FirstOrDefault();

            if (Orders==null )
            {

                var newOrder = new Order();
                newOrder.UserId = userId;
                _context.Add(newOrder);
                _context.SaveChangesAsync();
            }
            Orders = _context.Orders.Where(x => x.UserId == userId && x.State=="0").FirstOrDefault();
            if (Orders != null )
            {
                var productExist = _context.OrderProducts.Where(x => x.ProductId==ProductId && x.OrderId==Orders.Id).FirstOrDefault();
                if (productExist!=null)
                {
                    productExist.Quantity = productExist.Quantity + Quantity;
                    _context.Update(productExist);
                    _context.SaveChangesAsync();

                }
                else { 
                var userOrder =new OrderProduct {ProductId=product.Id,Quantity=Quantity,OrderId=Orders.Id};
                _context.Add(userOrder);
                _context.SaveChangesAsync();}

            }
            var products = _context.Products.Where(x => x.Id == ProductId);

            return View(products);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



     public IActionResult settings()
        {
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");


            int userID = (int)HttpContext.Session.GetInt32("UserId");
        var user = _context.Users.Where(x => x.Id == userID).SingleOrDefault();
        return View(user);
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> settings([Bind("Id,FullName,Email,Address,City,Birthdate,ImageFile,PhoneNumber")] User user ,string ImagePath)
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
            else
            {
                    user.ImagePath = ImagePath;
            }

            _context.Update(user);
            await _context.SaveChangesAsync();


        }
        return RedirectToAction("settings", "user");
      }





        public IActionResult LoginSettings()
        {
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            int userId = (int)HttpContext.Session.GetInt32("UserId");
            var userLogin = _context.Logins.Where(x => x.UserId == userId).SingleOrDefault();

            return View(userLogin);
        }

        [HttpPost]
        public IActionResult LoginSettings(string UserName, string NewUserName, string CurrentPassword, string Password)
        {
            int userId = (int)HttpContext.Session.GetInt32("UserId");
            var userLogin = _context.Logins.Where(x => x.UserId == userId).SingleOrDefault();
            if (userLogin != null)
            {
                if (_context.Logins.Where(x => x.Username == NewUserName).SingleOrDefault() != null)
                {
                    ModelState.AddModelError("NewUserName", "Username already exists");
                }
                else if (userLogin.Password != CurrentPassword && CurrentPassword != null)
                {
                    ModelState.AddModelError("CurrentPassword", "Your current password is wrong");
                }
                else
                {
                    if (Password != null)
                    {
                        userLogin.Password = Password;
                    }
                    if (NewUserName != null)
                    {
                        userLogin.Username = NewUserName;

                    }

                }

            }

            _context.Logins.Update(userLogin);
            _context.SaveChangesAsync();

            return RedirectToAction("LoginSettings", "user");
        }



        public IActionResult logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult SearchJoin(string text)
        {
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            text = text.ToLower();
         var pro = _context.Products.ToList();
          var  cat = _context.Categories.ToList();
          var  Proc = _context.ProductCategories.ToList();
          var  stores = _context.Stores.ToList();
           var Model= from pg in Proc
                      join p in pro on pg.Id equals p.CategoryId
                      join s in stores on p.StoreId equals s.Id
                      join c in cat on s.CategoryId equals c.Id
                      select new SearchJoin { category=c,store=s,product=p,productCategory=pg};

            var SearchS = Model.Where(x => x.store.Name == text).ToList();
            var SearchC = Model.Where(x => x.category.Name == text).ToList();
            var SearchP = Model.Where(x => x.product.Name == text).ToList();
            var SearchPC = Model.Where(x => x.productCategory.Name == text).ToList();

            if (SearchS.Count != 0) {
                ViewBag.Name = "store";

                return View(SearchS);
            }
            else if (SearchC.Count != 0) {
                ViewBag.Name = "category";

                return View(SearchC);
            }
            else if (SearchP.Count != 0) {
                ViewBag.Name = "product";

                return View(SearchP);
            }
            else if (SearchPC.Count != 0) {
                ViewBag.Name = "product";
                return View(SearchPC);
            }
            else
            return View();
        }



    }
}
