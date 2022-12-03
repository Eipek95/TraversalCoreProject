using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //List<Announcement> announcements = _announcementService.GetAll().Data;
            //List<AnnoucementListViewModel> model = new List<AnnoucementListViewModel>();
            //foreach (var item in announcements)
            //{
            //    AnnoucementListViewModel annoucementListViewModel = new AnnoucementListViewModel();
            //    annoucementListViewModel.ID = item.AmouncementID;
            //    annoucementListViewModel.Title = item.Title;
            //    annoucementListViewModel.Content = item.Content;

            //    model.Add(annoucementListViewModel);
            //}
            var values = _mapper.Map<List<AnnoucementListDto>>(_announcementService.GetAll().Data);
            return View(values);
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.Add(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnoucementUpdateDto>(_announcementService.Get(id).Data);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnoucementUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.Update(new Announcement()
                {
                    AmouncementID = model.AmouncementID,
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteAnnouncement(int id)
        {
            try
            {
                var isAnnouncement = _announcementService.Get(id).Data;
                _announcementService.Delete(isAnnouncement);
                return Json(new { Status = 1 });
            }
            catch (Exception ex)
            {
                return Json(new { Status = 0, Errormessage = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult Deneme(DateTime dateTime1, DateTime dateTime2)
        {
            var c = new Context();
            var values = c.Announcements.Where(x => x.Date < dateTime2 && x.Date > dateTime1).ToList();
            var jsonCity = JsonConvert.SerializeObject(values);
            return Json(jsonCity);
        }
    }
}
