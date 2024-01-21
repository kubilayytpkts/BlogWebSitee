using BlogWebSite.DataAccess.Concrete;
using BlogWebSite_BussinessLayer.Service;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;
namespace BlogWebSitee.Controllers
{
    public class EmailServiceController : Controller
    {
        private readonly IEmailService emailService;
        Context context=new Context();
        public EmailServiceController(IEmailService _emailService)
        {
            this.emailService = _emailService;
        }

        public async Task<ActionResult> SendMail(CommunicationModel com)
        {
            bool success = false;
           var receiverMail = context.Mails.Where(x => x.MailID == 1).Select(y => y.ReceiverMail).FirstOrDefault();

            var email = receiverMail;
            var subject = $"{com.ComName}'den Mail var !";
            var message = $"{com.ComEmail} : {com.ComDescription}";

            try
            {
                if (com.ComDescription != null && com.ComEmail != null && com.ComName != null)
                {
                    await emailService.SendEmailAsync(email, subject, message);
                    success = true;
                }
                else
                    success = false;

            }
            catch (Exception ex)
            {
                // Hata yönetimi 
            }
            return Json(success);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
