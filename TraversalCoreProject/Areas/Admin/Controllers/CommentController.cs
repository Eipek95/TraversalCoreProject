using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IActionResult Index()
        {
            var values = _commentService.GetListCommentWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.Get(id);
            var data = _commentService.Delete(values.Data);
            return RedirectToAction("Index");
        }
    }
}
