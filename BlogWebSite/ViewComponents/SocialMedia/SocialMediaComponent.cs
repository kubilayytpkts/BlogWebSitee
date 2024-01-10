using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.SocialMedia
{
	public class SocialMediaComponent : ViewComponent
	{
		SocialMediaManager socialMediaManager=new SocialMediaManager(new EfSocialMediaRepository());
		public IViewComponentResult Invoke()
		{
			var value = socialMediaManager.ListAll();
			ViewBag.socialMediaValue = value;

			return View();
		}
	}
	public class SocialMediaBlogComponent : ViewComponent
	{
		SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());
		public IViewComponentResult Invoke()
		{
			var value = socialMediaManager.ListAll();
			ViewBag.socialMediaValue = value;

			return View();
		}
	}
}
