using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.ViewComponents.SocialMedia
{
	public class SocialMediaComponent:ViewComponent
	{
		SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());
		public IViewComponentResult Invoke()
		{
			var value = socialMediaManager.ListAll();
			ViewBag.socialMediaValue = value;

			return View();
		}
	}
	//public class SocialMediaBlogComponent:ViewComponent
	//{
	//	SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());
	//	public IViewComponentResult Invoke()
	//	{
	//		var value = socialMediaManager.ListAll();
	//		ViewBag.socialMediaValue = value;

	//		return View();
	//	}
	//}
}
