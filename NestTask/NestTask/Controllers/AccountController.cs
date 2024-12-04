using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NestTask.DAL;
using NestTask.Models;
using NestTask.ViewModels.Account;

namespace NestTask.Controllers
{
    public class AccountController : Controller
    {
        AppDBContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(AppDBContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            this._userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterVm vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser user = new AppUser();
            {
                user.Email = vm.Email;
                user.Name = vm.UserName;

            };
            _userManager.CreateAsync(user, vm.Password);
            return RedirectToAction("Index","Home");
        }
    }
}
