using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestTask.DAL;
using NestTask.Models;

namespace NestTask.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class SliderController : Controller
    {
        AppDBContext _context;

        public SliderController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var tags = await _context.Sliders.ToListAsync();
            return View(tags);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider == null){
                return NotFound();
            }
            _context.Sliders.Remove(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Slider slider)
        {
            if (slider == null)
            {
                return NotFound();
            }
            var oldslider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);
            if (oldslider == null)
            {
                return NotFound();
            }
            oldslider.Title = slider.Title;
            oldslider.SubTitle = slider.SubTitle;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
       
    }
}
