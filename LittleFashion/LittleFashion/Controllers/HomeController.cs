using LittleFashion.DAL;
using LittleFashion.Models;
using LittleFashion.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LittleFashion.Controllers
{
    public class HomeController : Controller
    {
        AppDBContext dbContext;
        public HomeController(AppDBContext appdBContext)
        {
            dbContext = appdBContext;
        }
        public IActionResult Index()
        {
            List<Product> products = dbContext.Products.ToList();
            return View(products);
        }
        public IActionResult Detail(int? id)
        {
            List<Product> products = dbContext.Products.ToList();

            if (id == null) { return NotFound(); }
            var product = dbContext.Products.FirstOrDefault(x => x.Id == id);
            HomeVM vm = new HomeVM()
            {
                Product = product,
                Products = products
            };
            return View(vm);
        }
    }
}
