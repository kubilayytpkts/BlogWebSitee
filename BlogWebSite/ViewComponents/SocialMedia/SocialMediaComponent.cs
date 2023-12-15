using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.SocialMedia
{
	public class SocialMediaComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
