using BlogWebSite_BussinessLayer.Service;
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

		public async Task<ActionResult> SendMail()
		{
			var email = "onur35710@hotmail.com";
			var subject = "Deneme";
			var message = "Selam";
			await emailService.SendEmailAsync(email,subject,message);
			return View();
		}

        public IActionResult Index()
		{
			return View();
		}
	}
}
