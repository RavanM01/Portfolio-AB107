using Microsoft.AspNetCore.Mvc;

namespace ProniaTask.Areas.Manage.Controllers
{
    public class PanelController : Controller
    {
        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
