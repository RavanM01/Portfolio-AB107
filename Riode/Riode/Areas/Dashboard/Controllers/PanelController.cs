using Microsoft.AspNetCore.Mvc;

namespace Riode.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
