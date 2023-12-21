using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
	public class CommunicationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult AddCommunication()
		{
			return View();
		}
	}
}
