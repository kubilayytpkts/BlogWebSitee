using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Banner
{
    public class BannerComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
