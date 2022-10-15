using EntityLayer.Concrete;
using EntityLayer.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegissterViewModelDto userRegissterViewModel)
        {
            AppUser appUser = new AppUser()
            {
                Name = userRegissterViewModel.Name,
                Surname = userRegissterViewModel.Surname,
                Email = userRegissterViewModel.Mail,
                UserName = userRegissterViewModel.Username
            };
            if (userRegissterViewModel.Password == userRegissterViewModel.ConfirmPassword)
            {
                //parola hashlenecektir
                var result = await _userManager.CreateAsync(appUser, userRegissterViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
