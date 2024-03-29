﻿using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSitee.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.ViewComponents.Footer
{
	public class FooterComponent:ViewComponent
	{
		UserManager userManager = new UserManager(new EfUserModelRepository());
		SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());
		EmailServiceController emailServiceController = new EmailServiceController(new EmailManager());
		public IViewComponentResult Invoke()
		{
			int userId = 2;

			var userValue = userManager.ListAll().Where(x => x.UserID == 2).Select(y => y.Mail).FirstOrDefault();
			if (userValue != null)
			{
				ViewBag.userValue = userValue;
			}

			var socialMediaValue = socialMediaManager.ListAll();
			if (socialMediaValue != null)
			{
				ViewBag.socialMediaValue = socialMediaValue;
			}

			return View();
		}
	}
}
