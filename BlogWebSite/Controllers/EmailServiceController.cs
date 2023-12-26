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
                emailService.SendEmailAsync(email, subject, message);
                success = true;
            }
            catch (Exception ex)
            {
                // Hata yönetimi gerekiyorsa burada işlem yapabilirsiniz.
            }

            ViewBag.Success = success;

            return View("~/Views/Blog/Index.cshtml"); // veya istediğiniz başka bir view adı
        }

        public IActionResult Index()
		{
			return View();
		}
	}
}
