using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        //============================================================================
        //Bütün Yorumları getirme
        public IActionResult Index()
        {
            var result = commentManager.ListAll();

            return View(result);
        }

        //============================================================================
        //Yorum statusu değiştirme
        [HttpPost]
        public async Task<IActionResult> ChangeCommentStatus(int id,string type)
        {
            var success = commentManager.Validation(id, type);

            return Json(new {success=success});
        }

        //============================================================================
        //Yorum İnceleme
        [HttpGet]
        public IActionResult ReviewComment(int id)
        {
            BlogManager blogManager =new BlogManager(new EfBlogRepository());

            var resultComment = commentManager.GetById(id);
            var blogName = blogManager.ListAll().Where(x=>x.BlogID == resultComment.BlogID).Select(y=>y.BlogTitle).FirstOrDefault();
            ViewData["blogName"] = blogName;

            return View(resultComment);
        }

        //============================================================================
        //Yorum Silme
        [HttpDelete]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var success = false ;

            if(id is not 0)
            {
                var deleteValue = commentManager.GetById(id);
                commentManager.Delete(deleteValue);
                success = true;
            }

            return Json(new {success=success});
        }
        
    }
}
