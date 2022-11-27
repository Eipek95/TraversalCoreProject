using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

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

        public IActionResult GetById(int DestinationID)
        {
            var result = _destinationService.Get(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(result.Data);
            return Json(jsonValues);
        }
        [HttpPost]
        public IActionResult DeleteCity(int id)
        {
            try
            {
                var values = _destinationService.Get(id);
                _destinationService.Delete(values.Data);
                return Json(new { Status = 1 });
            }
            catch (Exception ex)
            {
                return Json(new { Status = 0, Errormessage = ex.Message });
            }

        }
        [HttpPost]
        public IActionResult UpdateCity(Destination destination)
        {
            var values = _destinationService.Get(destination.DestinationID);
            _destinationService.Update(destination);
            var jvalues = JsonConvert.SerializeObject(destination);
            return View(jvalues);
        }
    }
}
