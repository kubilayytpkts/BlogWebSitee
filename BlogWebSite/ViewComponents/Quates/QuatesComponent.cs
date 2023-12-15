using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Quates
{
	public class QuatesComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
