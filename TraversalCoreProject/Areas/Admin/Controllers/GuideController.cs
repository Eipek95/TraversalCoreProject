using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var result = _guideService.GetAll();
            return View(result.Data);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            _guideService.Add(guide);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var result = _guideService.Get(id);
            return View(result.Data);
        }
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.Update(guide);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToGuideStatus(int id)
        {
            var result = _guideService.Get(id);
            if (result.Data.Status == true)
                result.Data.Status = false;
            else
                result.Data.Status = true;
            _guideService.Update(result.Data);
            return RedirectToAction("Index");
        }

    }
}
