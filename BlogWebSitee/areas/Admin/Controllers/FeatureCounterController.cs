using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureCounterController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureRepository());

        //============================================================================
        /// <summary>
        ///  Kullanıcı yeteneklerini getirir      
        /// </summary>
        public IActionResult Index()
        {
           var resultFeature = featureManager.GetById(1);

            return View(resultFeature);
        }

        /// <summary>
        ///  Kullanıcı yeteneklerini günceller      
        /// </summary>
        [HttpPost]
        public async Task <IActionResult> UpdateFeature(FeatureCounterModel model)
            {
            bool success = false;

            success = featureManager.Update(model);

            return Json(new { success = success });
        }

    }
}
