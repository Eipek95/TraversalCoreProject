using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values = _contactUsService.GetListContactUsByTrue();
            return View(values.Data);
        }

        public IActionResult MessageDetails(int ContactUsID)
        {
            var result = _contactUsService.Get(ContactUsID);
            var jsonValues = JsonConvert.SerializeObject(result.Data);
            return Json(jsonValues);
        }
    }
}
