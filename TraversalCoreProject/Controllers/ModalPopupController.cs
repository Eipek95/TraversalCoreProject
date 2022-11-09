using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class ModalPopupController : Controller
    {
        private readonly IGuideService _guideService;
        private readonly Context _context;

        public ModalPopupController(IGuideService guideService, Context context)
        {
            _guideService = guideService;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Guide> guides = new List<Guide>();
            guides = _guideService.GetAll().Data;
            //guides.Insert(0, new Guide { GuideID = 0, Name = "--Lütfen bir isim seçiniz--" });
            ViewBag.message = guides;
            return View();
            //var result = _guideService.GetAll();
            //return View(result.Data);
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {

            var result = _guideService.Get(id);
            var jsonGuide = JsonConvert.SerializeObject(result.Data);
            return Json(jsonGuide);
        }
        public IActionResult popupIndex()
        {
            return View();
        }
        public IActionResult JqueryView()
        {
            return View();
        }
        public IActionResult JqueryView2()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create2()
        {
            var result = _guideService.GetAll();
            var jsonGuide = JsonConvert.SerializeObject(result.Data);
            return Json(jsonGuide);
        }
        public IActionResult actionResult()
        {
            return View();
        }
    }
}
