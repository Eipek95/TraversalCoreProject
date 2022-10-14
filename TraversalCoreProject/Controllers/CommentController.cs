using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

namespace TraversalCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentState = true;
            var result = commentManager.Add(comment);
            if (result.IsSucess)
            {
                TempData["AlertMessage"] = result.Message.Replace('ı', 'i');
                TempData["IsSuccess"] = "success";
                Thread.Sleep(2000);
                return RedirectToAction("Index", "Destination");
            }
            TempData["AlertMessage"] = result.Message.Replace('ı', 'i');
            Thread.Sleep(2000);
            TempData["IsSuccess"] = "error";
            return RedirectToAction("Index", "Destination");
        }
    }
}
