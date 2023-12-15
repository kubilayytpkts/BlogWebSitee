using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Feature
{
    public class FeatureComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
