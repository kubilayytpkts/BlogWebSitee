using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var categoryValue = categoryManager.ListAll();
            ViewData["blogCount"]=categoryManager.ListAll().Where(x=>x.);
            return View(categoryValue);
        }

        //Burda kaldık


    }
}
