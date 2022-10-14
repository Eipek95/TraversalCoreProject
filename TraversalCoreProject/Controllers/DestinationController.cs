using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var result = destinationManager.GetAll();
            return View(result.Data);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.DestinationId = id;
            var result = destinationManager.Get(id);
            return View(result.Data);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
