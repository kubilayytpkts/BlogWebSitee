using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
