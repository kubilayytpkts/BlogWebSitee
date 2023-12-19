using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Banner
{
    public class BannerComponent : ViewComponent
    {
        BannerManager bannerManager=new BannerManager(new EfBannerRepository());
        public IViewComponentResult Invoke()
        {
            var value = bannerManager.GetById(1);

            return View(value);
        }
    }
}
