using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        private int blogId;
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            blogId = id;
            var resutValue = commentManager.ListAll(id);
            return PartialView(resutValue);
        }

        [HttpGet]
        public IActionResult AddComment()
        {
            ViewBag.blogId = blogId;
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(CommentModel comment)
        {
            return View();
        }
    }
}
