using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            TestimonialManager testimonialManager = new TestimonialManager(new EfTestmonialDal());
            var result = testimonialManager.GetAll();
            return View(result.Data);
        }
    }
}
