using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.About
{
	// 13 about Id = Main about 
	// 14 about Id = Article about 
	// 15 about Id = Blog about
	// don't remove just update
	public class AboutComponent : ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EfAboutRepository());
		public IViewComponentResult Invoke()
		{
			var mainAboutvalue = aboutManager.GetById(13);
			ViewBag.aboutValue = new List<AboutModel> { mainAboutvalue };
			var articleValue = aboutManager.GetById(14);

			if (articleValue.AboutText != null && articleValue.AboutTitle != null && articleValue.Status != false)
			{
				ViewBag.aboutValue1 = new List<AboutModel> { articleValue };
			}

			return View();
		}
	}
	public class AboutComponentBlog : ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EfAboutRepository());
		public IViewComponentResult Invoke()
			{
			var result = aboutManager.GetById(15);
			 ViewBag.aboutValue=new List<AboutModel>() { result};
			//ViewBag.resultValue = result;
			return View();
		}
	}
}
