using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
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

        public  IActionResult DeleteQuates(int id)
        {
            bool success = true;

            var result = _quotesManager.GetById(id);
            _quotesManager.Delete(result);

            return Json(new { success = success });
        }

    }
}
