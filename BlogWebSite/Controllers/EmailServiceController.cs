using BlogWebSite_BussinessLayer.Service;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
	public class EmailServiceController : Controller
	{
		private readonly IEmailService emailService;
        public EmailServiceController(IEmailService _emailService)
        {
				this.emailService= _emailService;
        }

		public async Task<ActionResult> SendMail(CommunicationModel com)
		{
            bool success = false;

            var email = "onur35710@hotmail.com";
            var subject = $"BLOG MESAJI : {com.ComEmail}";
            var message = $"{com.ComName} mesajı : {com.ComDescription}";

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
                // Hata yönetimi gerekiyorsa burada işlem yapabilirsiniz.
            }
            return Json(success);   
        }

        public IActionResult Index()
		{
			return View();
		}
	}
}
