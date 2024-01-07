using BlogWebSite_BussinessLayer.Service;
using BlogWebSite_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_BussinessLayer.Manager
{
	public class EmailManager : IEmailService
	{

		public Task SendEmailAsync(string email, string subject, string message)
		{
			var client = new SmtpClient("smtp-mail.outlook.com", 587)
			{
				EnableSsl = true,
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential("kubilaytopaktas@hotmail.com", "onurefe123")
			};

			return client.SendMailAsync(
				new MailMessage(from: "kubilaytopaktas@hotmail.com",
								to: email,
								subject,
								message));
		}

		public void Add(CommunicationModel value)
		{
			throw new NotImplementedException();
		}

		public void Delete(CommunicationModel value)
		{
			throw new NotImplementedException();
		}

		public CommunicationModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<CommunicationModel> ListAll()
		{
			throw new NotImplementedException();
		}

		public void Update(CommunicationModel value)
		{
			throw new NotImplementedException();
		}
	}
}
