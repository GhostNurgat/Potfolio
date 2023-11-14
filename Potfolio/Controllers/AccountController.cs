using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace Potfolio.Controllers
{
    using Potfolio.Models;
    using Potfolio.ViewModel;

    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpGet]
        public IActionResult Login(string? returnUrl = null) =>
            View(new LoginViewModel { ReturnUrl = returnUrl });
    }
}
