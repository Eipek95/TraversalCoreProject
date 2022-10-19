using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var result = _appUserService.GetAll();
            return View(result.Data);
        }
        public IActionResult DeleteUser(int id)
        {
            var getUserData = _appUserService.Get(id);
            var result = _appUserService.Delete(getUserData.Data);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var getUserData = _appUserService.Get(id);
            return View(getUserData.Data);
        }
        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            var getUserData = _appUserService.Update(appUser);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser(int id)
        {
            var getUserData = _appUserService.GetAll();
            return View(getUserData.Data);
        }
        public IActionResult ReservationUser(int id)
        {
            var getUserData = _reservationService.GetListWithReservationByAccepted(id);
            return View(getUserData.Data);
        }
    }
}
