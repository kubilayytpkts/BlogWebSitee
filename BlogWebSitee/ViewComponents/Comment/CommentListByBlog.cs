using BlogWebSite.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogWebSitee.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		Context dbContext = new Context();
		public IViewComponentResult Invoke(int id)
		{
			var result = dbContext.Blogs.Include(a => a.Comment).FirstOrDefault(c => c.BlogID == id);
			return View(result);
		}
	}
}
