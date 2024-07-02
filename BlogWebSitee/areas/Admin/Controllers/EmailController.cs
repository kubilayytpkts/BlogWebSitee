using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    public class EmailController : Controller
    {
        public MailSystemManager mailSystemManager = new MailSystemManager(new EfMailSystemRepository());
      
        public IActionResult Index()
        {
            var Mailvalue = mailSystemManager.GetById(1);

            return View(Mailvalue);
        }
    }
}
