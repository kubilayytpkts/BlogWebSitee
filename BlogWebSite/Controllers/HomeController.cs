using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
