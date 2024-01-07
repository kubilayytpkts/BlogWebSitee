using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var resutValue = commentManager.ListAll(id);
			return PartialView(resutValue);
		}

		[HttpGet]
		public IActionResult AddComment()
		{
			return View();	
		}

		[HttpPost]
		public IActionResult AddComment(CommentModel comment)
		{
			return View();
		}
	}
}
