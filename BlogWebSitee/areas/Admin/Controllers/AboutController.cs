using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager (new EfAboutRepository());
        public IActionResult Index()
        {
            List<AboutModel> aboutList = new List<AboutModel> ();
            var resultList = aboutManager.ListAll();

            foreach (var item in resultList)
            {
                GetPreview(item.AboutText, 30);
                aboutList.Add(item);
            }
         
            return View(aboutList);
        }
        private string GetPreview(string description,int wordCount)
        {
            if (string.IsNullOrEmpty(description)) 
                return description;

           var descriptionResult = description.Split(' ');

            if (descriptionResult.Length <= wordCount)
                return description;
            else
            {
                description = string.Join(" ", descriptionResult.Take(wordCount))+"...";
            }
             
            return description;
        }

    }
}
