using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var result = commentManager.ListAll();

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeCommentStatus(int id,string type)
        {
            var success = commentManager.Validation(id, type);

            return Json(new {success=success});
        }

        [HttpGet]
        public IActionResult ReviewComment(int id)
        {//burda kaldım view oluşturulacak 
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> ReviewComment(CommentModel comment)
        {
            return View();
        }
    }
}
