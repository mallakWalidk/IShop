using First_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace First_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ModelContext _context;

        public HomeController(ILogger<HomeController> logger,ModelContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            

                var home = _context.Homes.Where(x => x.Id == 1).FirstOrDefault();
                ViewBag.FirstDisc = home.FirstDescreption;
                ViewBag.SecondDisc = home.SecondDescreption;
                ViewBag.FirstImg = home.FirstImgPath;
                ViewBag.SecondImg = home.SecondImgPath;

            
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult about()
        {
            var home = _context.Homes.Where(x => x.Id == 1).FirstOrDefault();
            ViewBag.Name = home.SecondDescreption;

            var about = _context.AboutUs.Where(x => x.Id == 1).FirstOrDefault();
            ViewBag.FirstDisc = about.FirstDescreption;
            ViewBag.SecondDisc = about.SecondDescreption;
            ViewBag.Img = about.ImgPath;


            return View();
        }
        public IActionResult contact()
        {
            var contact = _context.ContactUs.Where(x => x.Id == 1).FirstOrDefault();
            ViewBag.facebook = contact.Facebook;
            ViewBag.email = contact.Email;
            ViewBag.instagram = contact.Instagram;
            ViewBag.phone = contact.Phonenumber;

            return View();
        }
        public IActionResult testimonial()
        {
            var customer = _context.Testimonials.Where(x => x.State == true).Include(s => s.User);

            return View(customer);
        }
        public IActionResult products(int Id)
        {
            var products = _context.Products.Where(x => x.StoreId == Id).Include(x => x.Category);
            return View(products);

        }

        public IActionResult product(int Id)
        {
            var product = _context.Products.Where(x => x.Id == Id);

            return View(product);

        }


        public IActionResult store(int Id)
        {
            var stores = _context.Stores.Where(x => x.CategoryId == Id);
            return View(stores);

        }


        public IActionResult category()
        {
            var cat = _context.Categories.ToList();
            return View(cat);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult search()
        {
            var category = _context.Categories.ToList();
            var store = _context.Stores.ToList();
            var result = Tuple.Create<IEnumerable<Category>, IEnumerable<Store>>(category, store);
            return View(result);
        }

        public IActionResult SearchJoin(string text)
        {
            ViewBag.ImagePath = HttpContext.Session.GetString("ImagePath");
            ViewBag.Fname = HttpContext.Session.GetString("Fname");

            text = text.ToLower();
            var pro = _context.Products.ToList();
            var cat = _context.Categories.ToList();
            var Proc = _context.ProductCategories.ToList();
            var stores = _context.Stores.ToList();
            var Model = from pg in Proc
                        join p in pro on pg.Id equals p.CategoryId
                        join s in stores on p.StoreId equals s.Id
                        join c in cat on s.CategoryId equals c.Id
                        select new SearchJoin { category = c, store = s, product = p, productCategory = pg };

            var SearchS = Model.Where(x => x.store.Name == text).ToList();
            var SearchC = Model.Where(x => x.category.Name == text).ToList();
            var SearchP = Model.Where(x => x.product.Name == text).ToList();
            var SearchPC = Model.Where(x => x.productCategory.Name == text).ToList();

            if (SearchS.Count != 0)
            {
                ViewBag.Name = "store";

                return View(SearchS);
            }
            else if (SearchC.Count != 0)
            {
                ViewBag.Name = "category";

                return View(SearchC);
            }
            else if (SearchP.Count != 0)
            {
                ViewBag.Name = "product";

                return View(SearchP);
            }
            else if (SearchPC.Count != 0)
            {
                ViewBag.Name = "product";
                return View(SearchPC);
            }
            else
                return View();
        }

    }
}
