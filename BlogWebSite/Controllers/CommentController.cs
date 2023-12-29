using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
