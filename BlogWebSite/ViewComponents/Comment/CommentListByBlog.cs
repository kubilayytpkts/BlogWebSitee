using BlogWebSite.DataAccess.Concrete;
using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogWebSite.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		Context dbContext = new Context();
		public IViewComponentResult Invoke(int id)
		{
			var result = dbContext.Blogs.Include(b => b.Comment).FirstOrDefault(c => c.BlogID == id);
			return View(result);
		}
	}
}
