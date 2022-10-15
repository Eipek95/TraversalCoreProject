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
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModelDto userSignInViewModelDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    userSignInViewModelDto.UserName,
                    userSignInViewModelDto.Password,
                    false,//hatırlayıp hatırlamaması
                    true//şifre beş defa yanlış girilirse hesap veritabanında kitlenir
                    );
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { Area = "Member" });
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
    }
}
