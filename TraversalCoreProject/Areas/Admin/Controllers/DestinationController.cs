using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var result = destinationManager.GetAll();
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
            var result = destinationManager.Add(destination);
            if (result.IsSucess)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteDestination(int id)
        {
            var getDeleteData = destinationManager.Get(id);
            var result = destinationManager.Delete(getDeleteData.Data);
            if (result.IsSucess)
            {
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var getUpdatedData = destinationManager.Get(id);
            return View(getUpdatedData.Data);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination getUpdatedData)
        {
            var result = destinationManager.Update(getUpdatedData);
            if (result.IsSucess)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
