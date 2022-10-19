using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var result = _destinationService.GetAll();
            return View(result.Data);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.DestinationId = id;
            var result = _destinationService.Get(id);
            return View(result.Data);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
