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
                GetPreview(item.AboutText, 15);
                aboutList.Add(item);
            }
         
            return View(aboutList);
        }

        public IActionResult GetAboutByID(int id)
        {
            return View();
        }

        public IActionResult PassivatingAbout(int id)
        {
            var selectedAbout = aboutManager.GetById(id);

            selectedAbout.Status = false;
            aboutManager.Update(selectedAbout);

           return Redirect("/Admin/About/Index");
        }
        public IActionResult ActivatedAbout(int id)
        {
            var selectedAbout = aboutManager.GetById(id);

            selectedAbout.Status = true;
            aboutManager.Update(selectedAbout);

            return Redirect("/Admin/About/Index");
        }

        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbout(AboutModel about)
        {
            aboutManager.Add(about);

            return Redirect("/Admin/About/Index");
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
