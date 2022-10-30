using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetAll().Data);
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            _destinationService.Add(destination);
            var result = JsonConvert.SerializeObject(destination);
            return Json(result);
        }

        public IActionResult GetById(int id)
        {
            var result = _destinationService.Get(id);
            var jsonValues = JsonConvert.SerializeObject(result.Data);
            return Json(jsonValues);
        }

    }
}
