using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.GetAll().Data;
            List<AnnoucementListViewModel> model = new List<AnnoucementListViewModel>();
            foreach (var item in announcements)
            {
                AnnoucementListViewModel annoucementListViewModel = new AnnoucementListViewModel();
                annoucementListViewModel.ID = item.AmouncementID;
                annoucementListViewModel.Title = item.Title;
                annoucementListViewModel.Content = item.Content;

                model.Add(annoucementListViewModel);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(string x)
        {
            return View();
        }
    }
}
