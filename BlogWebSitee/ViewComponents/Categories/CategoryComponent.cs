using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.ViewComponents.Categories
{
	public class CategoryComponent:ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var resultCategory = categoryManager.ListAll().ToList();
			return View(resultCategory);
		}
	}
}
