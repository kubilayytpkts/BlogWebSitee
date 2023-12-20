using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Quates
{
	public class QuatesComponent:ViewComponent
	{
		QuotesManager quotesManager = new QuotesManager(new EfQuotesRepository());
		public IViewComponentResult Invoke()
		{
		   var quotesValue=quotesManager.ListAll();
		   ViewBag.quoteValue = quotesValue;
			return View();
		}
	}
}
