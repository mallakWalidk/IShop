using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using First_Project.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace First_Project.Controllers
{
    public class HomePageController : Controller
    {
        private readonly ModelContext _context;

        private readonly IWebHostEnvironment _hostEnvironment;

        public HomePageController(ModelContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _hostEnvironment = webHostEnviroment;
        }
        // GET: HomePageoller
        public async Task<IActionResult> Index()
        {
            return View(await _context.Homes.ToListAsync());
        }

        // GET: HomePageoller/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            id = 1;
            if (id == null)
            {
                return NotFound();
            }

            var home = await _context.Homes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (home == null)
            {
                return NotFound();
            }

            return View(home);
        }

        // GET: HomePageoller/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HomePageoller/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstDescreption,SecondDescreption,FirstImgPath,SecondImgPath,FirstImgFile,SecondImgFile")] Home home)
        {
            if (ModelState.IsValid)
            {
                if (home.FirstImgFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" + home.FirstImgFile.FileName;
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await home.FirstImgFile.CopyToAsync(fileStream);
                    }
                    home.FirstImgPath = fileName;
                }

                if (home.SecondImgFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" + home.SecondImgFile.FileName;
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await home.FirstImgFile.CopyToAsync(fileStream);
                    }
                    home.SecondImgPath = fileName;
                }
                _context.Add(home);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
             
            }
            return View(home);
        }

        // GET: HomePageoller/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            id = 1;
            var home = await _context.Homes.FindAsync(id);
            if (home == null)
            {
                return NotFound();
            }
            return View(home);
        }

        // POST: HomePageoller/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( [Bind("FirstDescreption,SecondDescreption,FirstImgPath,SecondImgPath,FirstImgFile,SecondImgFile")] Home home)
        {
            home.Id = 1;

            if (ModelState.IsValid)
            {
                try
                {
                    if (home.FirstImgFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Guid.NewGuid().ToString() + "_" + home.FirstImgFile.FileName;
                        string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await home.FirstImgFile.CopyToAsync(fileStream);
                        }
                        home.FirstImgPath = fileName;
                    }

                    if (home.SecondImgFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Guid.NewGuid().ToString() + "_" + home.SecondImgFile.FileName;
                        string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await home.SecondImgFile.CopyToAsync(fileStream);
                        }
                        home.SecondImgPath = fileName;
                    }

                    _context.Update(home);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeExists(home.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
            return View(home);
        }

        // GET: HomePageoller/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var home = await _context.Homes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (home == null)
            {
                return NotFound();
            }

            return View(home);
        }

        // POST: HomePageoller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var home = await _context.Homes.FindAsync(id);
            _context.Homes.Remove(home);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeExists(decimal id)
        {
            return _context.Homes.Any(e => e.Id == id);
        }
    }
}
