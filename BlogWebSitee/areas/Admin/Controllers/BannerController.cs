using BlogWebSite.DataAccess.Abstract;
using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        BannerManager bannerManager = new BannerManager(new EfBannerRepository());
        public IActionResult Index()
        {
            var result = new List<BannerModel>();
            result = bannerManager.ListAll();

            return View(result);
        }
        public IActionResult UpdateBanner(BannerModel banner,IFormFile bannerPhoto) 
        {
            bool success = false;

            if(Validation(banner,bannerPhoto))
            {
                var fileExtension = Path.GetExtension(bannerPhoto.FileName);

                var fileName = Guid.NewGuid().ToString() + fileExtension;

                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/author", "images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    bannerPhoto.CopyTo(stream);
                }
                banner.BannerPhoto = "/author/images/" + fileName;

                var result = bannerManager.GetById(1);

                result.Name = banner.Name;
                result.Surname = banner.Surname;
                result.BannerPhoto = banner.BannerPhoto;
                result.BannerShortAbout= banner.BannerShortAbout;
                result.BannerShortAbout1= banner.BannerShortAbout1;

                bannerManager.Update(result);

                success = true;
                return Json(new { success = success });
            }
            else
            {
                if(!string.IsNullOrEmpty(banner.Name) && !string.IsNullOrEmpty(banner.Surname) &&
              !string.IsNullOrEmpty(banner.BannerShortAbout1) && !string.IsNullOrEmpty(banner.BannerShortAbout) && !string.IsNullOrEmpty(banner.ShortHelloText))
                {

                    var result = bannerManager.GetById(1);

                    result.Name = banner.Name;
                    result.Surname = banner.Surname;
                    result.BannerShortAbout = banner.BannerShortAbout;
                    result.BannerShortAbout1 = banner.BannerShortAbout1;

                    bannerManager.Update(result);

                    success = true;
                    return Json(new { success = success });

                }

            }

            return Json(new { success = success });
        }
        private bool Validation(BannerModel banner,IFormFile bannerPhoto)
        {
            if(bannerPhoto !=null && !string.IsNullOrEmpty(banner.Name) && !string.IsNullOrEmpty(banner.Surname) &&
              !string.IsNullOrEmpty(banner.BannerShortAbout1) && !string.IsNullOrEmpty(banner.BannerShortAbout) && !string.IsNullOrEmpty(banner.ShortHelloText))
            {
                return true;
            }
            return false;
        }
    }
}
