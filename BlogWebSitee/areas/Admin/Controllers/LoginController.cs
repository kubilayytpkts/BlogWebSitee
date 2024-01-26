using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

			if (user.Mail != null && user.password != null)
			{
				var result = loginManager.GetAdminInformation(user.Mail, user.password);

				if (validateMethod(result))
				{
					var claims = new List<Claim>
					{
						new Claim(ClaimTypes.Name,result.Name),
						new Claim(ClaimTypes.Role,"Admin")
					};

					var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
					var authProperties = new AuthenticationProperties();

					await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    return Redirect("/Admin/Home/Index");
                }
				else
				{
					ViewBag.errorMessage = "Kullanıcı bilgileriniz hatalı lütfen tekrar kontrol edin ! ";
                }
					
			}
			else
			{
				ViewBag.errorMessage = "Lütfen gerekli alanları doldurunuz ! ";

            }
			return View();
        }
		private bool validateMethod(UserModel parameter) 
		{
			if(parameter !=null)
				return true;

			 else
				return false;
		}
    }
}
