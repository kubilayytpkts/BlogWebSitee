using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.areas.Admin.Controllers
{
	[Area("Admin")]
	public class LoginController : Controller
	{
		LoginManager loginManager = new LoginManager(new EfUserModelRepository());

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			return View();
		}

		[HttpPost]
        public async Task<IActionResult> Index(UserModel user)
        {
			bool flag = false;

			if (user.Name != null && user.password != null)
			{
				var result = loginManager.GetAdminInformation(user.Mail, user.password);
				if (result != null)
					return RedirectToAction("Index", "Blog");
			}
			else
			{

			}
			return View();
        }
    }
}
