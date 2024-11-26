using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
