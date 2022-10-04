using Microsoft.AspNetCore.Mvc;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace First_Project.Controllers
{
    public class invoice : Controller
    {
        public IActionResult Index()
        {
            Response.ContentType = "application/pdf";
            Response.Headers.Add("Content-disposition", "attachment; filename=tokens.pdf");



            return View();
        }
    }
}
