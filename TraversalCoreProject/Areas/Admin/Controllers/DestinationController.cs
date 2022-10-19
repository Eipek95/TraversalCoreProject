using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private IDestinationService _destinationService;

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
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            var result = _destinationService.Add(destination);
            if (result.IsSucess)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteDestination(int id)
        {
            var getDeleteData = _destinationService.Get(id);
            var result = _destinationService.Delete(getDeleteData.Data);
            if (result.IsSucess)
            {
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var getUpdatedData = _destinationService.Get(id);
            return View(getUpdatedData.Data);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination getUpdatedData)
        {
            var result = _destinationService.Update(getUpdatedData);
            if (result.IsSucess)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
