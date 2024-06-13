using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuatesController : Controller
    {
        QuotesManager _quotesManager = new QuotesManager(new EfQuotesRepository());
      
        [HttpGet]
        public IActionResult Index()
        {
            var result = _quotesManager.ListAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddQuates()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteQuates(int id)
        {
            bool success = true;

            var result = _quotesManager.GetById(id);
            _quotesManager.Delete(result);

            return Json(new { success = success });
        }

        [HttpGet]
        public async Task<IActionResult> EditQuates(int id)
        {
            var result = _quotesManager.GetById(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> EditQuates(QuotesModel model)
        {
            bool success; 

           success = _quotesManager.Update(model);

            return Json(new {success=success});
        }

    }
}
