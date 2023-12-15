using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Footer
{
	public class FooterComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
