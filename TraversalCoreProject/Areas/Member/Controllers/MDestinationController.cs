using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class MDestinationController : Controller
    {
        DestinationManager destinationManage = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var result = destinationManage.GetAll();
            return View(result.Data);
        }
    }
}
