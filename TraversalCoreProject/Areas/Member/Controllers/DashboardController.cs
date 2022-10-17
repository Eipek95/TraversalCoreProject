using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var authenticUser = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.authenticUser = authenticUser.Name + " " + authenticUser.Surname;
            ViewBag.authenticUserImage = authenticUser.ImageUrl;
            return View();
        }
    }
}
