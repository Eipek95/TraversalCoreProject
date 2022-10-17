using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager _reservationManager = new ReservationManager(new EfReservationDal());
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var authenticeUserID = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = _reservationManager.GetListWithReservationByAccepted(authenticeUserID.Id);
            @TempData["AlertMessage"] = result.IsSucess.ToString();
            return View(result.Data);
        }
        public async Task<IActionResult> MyOldReservation()
        {
            var authenticeUserID = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = _reservationManager.GetListWithReservationByPrevious(authenticeUserID.Id);
            @TempData["AlertMessage"] = result.IsSucess.ToString();
            return View(result.Data);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var authenticUser = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = _reservationManager.reservationDetailsDtos(authenticUser.Id);
            @TempData["AlertMessage"] = result.IsSucess.ToString();
            //var result = _reservationManager.GetListWithReservationByWaitApproval(authenticUser.Id);
            return View(result.Data);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            var result = _destinationManager.GetAll();
            List<SelectListItem> values = (from x in result.Data
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            //@TempData["AlertMessage"] = "elma";
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserID = 3;
            reservation.Status = "onay bekliyor";
            _reservationManager.Add(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }

}
