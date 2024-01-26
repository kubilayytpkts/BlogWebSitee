using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
