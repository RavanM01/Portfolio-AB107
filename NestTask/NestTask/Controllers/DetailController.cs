using Microsoft.AspNetCore.Mvc;

namespace NestTask.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
