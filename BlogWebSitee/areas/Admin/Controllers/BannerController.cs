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

        //============================================================================
        //Banner verilerini getirme
        [HttpGet]
        public IActionResult Index()
        {
            var result = bannerManager.GetById(1);

            return View(result);
        }
        //Banner verilerini güncelleme
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(BannerModel banner,IFormFile bannerPhoto) 
        {
            bool success;
            try
            {
                if (Validation(banner, bannerPhoto))
                {
                   bannerManager.Change_Product_WithImage(banner, bannerPhoto);
                }

                else
                {
                    if (!IsValid(banner))
                        return Json(new { success = false });

                    var result = bannerManager.GetById(1);
                    result.Name = banner.Name;
                    result.Surname = banner.Surname;
                    result.BannerShortAbout = banner.BannerShortAbout;
                    result.BannerShortAbout1 = banner.BannerShortAbout1;
                    bannerManager.Update(result);

                    return Json(new { success = true });
                }
            }
            catch (Exception )
            {
                throw;
            }
            success = true;

            return Json(new { success = success });
        }

        //================================YARDIMCIMCI METHODLAR============================================
        //banner modeli ve resim olup olmadıgını kontrol eder
        private bool Validation(BannerModel banner, IFormFile bannerPhoto)
        {
            if (bannerPhoto == null || bannerPhoto.Length <= 0)
                return false;

            if (string.IsNullOrEmpty(banner.Name))
                return false;

            if (string.IsNullOrEmpty(banner.Surname))
                return false;

            if (string.IsNullOrEmpty(banner.BannerShortAbout1))
                return false;

            if (string.IsNullOrEmpty(banner.BannerShortAbout))
                return false;

            if (string.IsNullOrEmpty(banner.ShortHelloText))
                return false;

            return true;
        }

        //============================================================================
        //banner modeli kontrol eder
        private bool IsValid(BannerModel banner)
        {
            if (string.IsNullOrEmpty(banner.Name))
                return false;

            if (string.IsNullOrEmpty(banner.Surname))
                return false;

            if (string.IsNullOrEmpty(banner.BannerShortAbout1))
                return false;

            if (string.IsNullOrEmpty(banner.BannerShortAbout))
                return false;

            if (string.IsNullOrEmpty(banner.ShortHelloText))
                return false;

            return true;
        }
    }
}
