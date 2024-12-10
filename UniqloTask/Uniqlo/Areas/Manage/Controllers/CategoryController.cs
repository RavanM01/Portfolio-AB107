using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uniqlo.Areas.DTOs.Category;
using Uniqlo.Areas.Manage.Common;
using Uniqlo.DAL;
using Uniqlo.Models;

namespace Uniqlo.Areas.Manage.Controllers
{
    public class CategoryController : BaseController
    {
        AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_context.Categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryDto category)
        {
            Category category1 = new Category()
            {
                Name = category.Name
            };
            _context.Categories.Add(category1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) { return NotFound(); }
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            if (id == null) return BadRequest();
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (category.Id == null) return BadRequest();
            var oldCategory = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (oldCategory == null) return NotFound();
            oldCategory.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
