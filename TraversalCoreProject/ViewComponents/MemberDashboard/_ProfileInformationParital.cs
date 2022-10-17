using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _ProfileInformationParital : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformationParital(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var authenticUser = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.authenticUser = authenticUser.Name + " " + authenticUser.Surname;
            ViewBag.authenticUserPhone = authenticUser.PhoneNumber;
            ViewBag.authenticUserMail = authenticUser.Email;
            return View();
        }
    }
}
