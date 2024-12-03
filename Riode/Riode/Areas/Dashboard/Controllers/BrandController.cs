using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Riode.DAL;
using Riode.Models;

namespace Riode.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class BrandController : Controller
    {
        AppDBContext _context;

        public BrandController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.brands.Include(x=>x.Products).ToListAsync();
            return View(categories);
        }
        [HttpGet]
        
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            _context.brands.Add(brand);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var brand = _context.brands.FirstOrDefault(x => x.Id == id);
            if (brand == null) { return NotFound(); }
            _context.brands.Remove(brand);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null) { BadRequest(); }
            var brand = _context.brands.FirstOrDefault(x => x.Id == id);
            if (brand == null) { return NotFound(); }
            return View(brand);
        }
        [HttpPost]
        public IActionResult Update(Brand brand)
        {
            if (brand == null) { return NotFound(); }
            var oldbrand = _context.brands.FirstOrDefault(x=>x.Id == brand.Id);
            if (oldbrand == null) { return NotFound(); }
            oldbrand.Name = brand.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
