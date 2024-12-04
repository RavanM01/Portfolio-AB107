using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestTask.DAL;
using NestTask.Models;

namespace NestTask.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CategoryController : Controller
    {
        AppDBContext _context;

        public CategoryController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            if (category == null)
            {
                return NotFound();
            }
            var oldcategory = _context.Categories.FirstOrDefault(x=>x.Id == category.Id);
            if (oldcategory == null)
            {
                return NotFound();
            }
            oldcategory.Name = category.Name;
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
