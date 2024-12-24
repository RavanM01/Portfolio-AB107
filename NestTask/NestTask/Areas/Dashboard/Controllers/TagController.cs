using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestTask.DAL;
using NestTask.Models;

namespace NestTask.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TagController : Controller
    {
        AppDBContext _context;

        public TagController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tags = await _context.Tags.ToListAsync();
            return View(tags);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tag = _context.Tags.FirstOrDefault(x => x.Id == id);
            if (tag == null)
            {
                return NotFound();
            }
            _context.Tags.Remove(tag);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tag = _context.Tags.FirstOrDefault(x => x.Id == id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }
        [HttpPost]
        public IActionResult Update(Tag tag)
        {
            if (tag == null)
            {
                return NotFound();
            }
            var oldtag = _context.Tags.FirstOrDefault(x => x.Id == tag.Id);
            if (oldtag == null)
            {
                return NotFound();
            }
            oldtag.Name = tag.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
