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
        public IActionResult Index()
        {
           var resultFeature = featureManager.ListAll();

            return View(resultFeature);
        }

        public async Task <IActionResult> UpdateFeature(FeatureCounterModel model)
            {
            bool success = false;

            success = featureManager.Update(model);

            return Json(new { success = success });
        }

    }
}
