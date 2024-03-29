﻿using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.ViewComponents.SocialMedia
{
	public class SocialMediaComponentOfBlog:ViewComponent
	{
		SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());
		public IViewComponentResult Invoke()
		{
			var resultBlogs = socialMediaManager.ListAll().ToList();
			return View(resultBlogs);
		}
	}
}
