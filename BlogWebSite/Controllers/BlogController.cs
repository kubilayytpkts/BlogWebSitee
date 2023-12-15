using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
