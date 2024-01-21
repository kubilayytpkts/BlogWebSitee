using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace BlogWebSitee.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> AddComment(CommentModel comment)
        {
            bool success = false;

            try
            {
                if (!string.IsNullOrEmpty(comment.NameSurname) && !string.IsNullOrEmpty(comment.Description) && !string.IsNullOrEmpty(comment.Email))
                {
                    comment.DateTime = DateTime.Now;
                    commentManager.Add(comment);
                    success = true;
                }
            }
            catch (Exception)
            {

            }

            return Json(success);
        }
    }
}
