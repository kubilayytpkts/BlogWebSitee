using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var result = socialMediaManager.GetById(1);

            return View(result);
        }

        [HttpPost]
        public IActionResult Index(SocialMediaModel socialMedia)
        {
           var success = socialMediaManager.Update(socialMedia);

            return Json(new {success = success});
        }
    }
}
