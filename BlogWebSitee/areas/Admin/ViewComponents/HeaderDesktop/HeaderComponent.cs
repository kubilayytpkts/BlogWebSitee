using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Areas.Admin.Controllers.ViewComponents.HeaderDesktop
{
    public class HeaderComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
