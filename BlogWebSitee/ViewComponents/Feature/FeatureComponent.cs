using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.ViewComponents.Feature
{
	public class FeatureComponent:ViewComponent
	{

		FeatureManager featureManager = new FeatureManager(new EfFeatureRepository());
		public IViewComponentResult Invoke()
		{
			var featureValue = featureManager.ListAll();
			if (featureValue != null)
			{
				ViewBag.featureValue = featureValue;
			}

			var featureTitle = featureManager.ListAll().Where(x => x.FeatureTitle != null).Select(y => y.FeatureTitle).FirstOrDefault();
			if (featureTitle != null)
			{
				ViewBag.featureTitle = featureTitle;
			}

			return View();
		}
	}
}
