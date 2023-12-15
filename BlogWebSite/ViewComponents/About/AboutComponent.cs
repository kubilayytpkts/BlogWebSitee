using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.About
{
    public class AboutComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
