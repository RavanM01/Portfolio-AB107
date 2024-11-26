using CoffeeShop.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        AppDBContext _db;
        public HomeController(AppDBContext appDBContext)
        {
            
            _db = appDBContext;
        }
        public IActionResult Index()
        {
            var products = _db.products.ToList();
            return View(products);
        }
    }
}
