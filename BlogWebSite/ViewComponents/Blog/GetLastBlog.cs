using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogWebSite.ViewComponents.Blog
{
	public class GetLastBlog:ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var resultBlogs = blogManager.ListAll().OrderByDescending(x => x.BlogDateTime).Take(5).ToList();
			return View(resultBlogs);
		}
	}
}
