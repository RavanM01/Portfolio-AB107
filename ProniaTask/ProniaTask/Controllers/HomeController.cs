using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaTask.DAL;
using ProniaTask.Models;
using ProniaTask.ViewModels;

namespace ProniaTask.Controllers
{
    public class HomeController : Controller
    {
        AppDBContext dbContext;
        public HomeController(AppDBContext appDBContext)
        {
            dbContext = appDBContext;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = dbContext.sliders.ToList();
            List<Product> products = dbContext.Products.Include(p=>p.ProductImages).ToList();

            HomeVM vm = new HomeVM()
            {
                Sliders = sliders,
                Products = products,
            };
            return View(vm);
        }
    }
}
