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

		public IActionResult Giris()
		{
			return View("Index");
		}

		
		public async Task<IActionResult> Index(UserModel user)
		{
			bool flag = false;
			var result = loginManager.GetAdminInformation(user.Mail, user.password);

			if(result !=null)
			{
				flag = true;
			}				
			return Json(flag);
		}

	}
}
