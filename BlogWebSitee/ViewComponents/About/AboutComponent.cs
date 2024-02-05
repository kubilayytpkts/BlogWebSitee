using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.ViewComponents.About
{
	public class AboutComponent:ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EfAboutRepository());
		public IViewComponentResult Invoke()
		{
			var mainAbout = aboutManager.ListAll().Where(x => x.AboutID == 13).ToList();
			ViewBag.mainAboutValue = mainAbout;

			var otherAbouts=aboutManager.ListAll().Where(x=>x.AboutID != 13 & x.Status==true).ToList();
			ViewBag.otherAboutsValue = otherAbouts;

            //var mainAboutvalue = aboutManager.GetById(13);

            //if(mainAboutvalue.Status!=false)
            //             ViewBag.aboutValue = new List<AboutModel> { mainAboutvalue };

            //         var articleValue = aboutManager.GetById(14);

            //if (articleValue.AboutText != null && articleValue.AboutTitle != null && articleValue.Status != false)
            //	ViewBag.aboutValue1 = new List<AboutModel> { articleValue };

            return View();
		}
	}
	public class AboutComponentBlog :ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EfAboutRepository());
		public IViewComponentResult Invoke()
		{
			var result = aboutManager.GetById(15);
			ViewBag.aboutValue = new List<AboutModel>() { result };
			//ViewBag.resultValue = result;
			return View();
		}
	}
}

