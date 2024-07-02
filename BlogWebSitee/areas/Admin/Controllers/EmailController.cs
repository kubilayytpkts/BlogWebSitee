using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSitee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmailController : Controller
    {
        public MailSystemManager mailSystemManager = new MailSystemManager(new EfMailSystemRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var Mailvalue = mailSystemManager.GetById(1);

            return View(Mailvalue);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmail(MailModel mail)
        {
            var success = false;

            if(mail is not null)
            {
                mailSystemManager.Update(new MailModel
                {
                    MailID = mail.MailID,
                    Port = mail.Port,
                    ReceiverMail=mail.ReceiverMail,
                    SenderMail=mail.SenderMail,
                    SenderMailPassword=mail.SenderMailPassword,
                    SMTP=mail.SMTP,
                });
                success = true;
            }
            return Json(new { success = success });
        }
    }
}
