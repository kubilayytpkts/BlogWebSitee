using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var categoryValue = categoryManager.ListAll();
            return View(categoryValue);
        }

        [HttpGet]
        public async Task<IActionResult> ReviewCategory(int id)
        {
            var categoryValue = categoryManager.GetById(id);
            return View(categoryValue);
        }

        [HttpPut]
        public async Task<IActionResult> EditCategory(CategoryModel category)
        {
            var success=false;

            if (category is not null)
            {
                categoryManager.Update(new CategoryModel
                {
                    CategoryDescription = category.CategoryDescription,
                    CategoryName = category.CategoryName,
                    CategoryID = category.CategoryID,
                    Status= category.Status,
                });
                success = true;
            }
            return Json(new {success=success});
        }
    }
}
