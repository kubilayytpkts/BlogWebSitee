using BlogWebSite.DataAccess.Abstract;
using BlogWebSite.DataAccess.Concrete;
using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Service;
using BlogWebSite_Entity;
using Microsoft.EntityFrameworkCore;
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

		Context context = new Context();

        public Task SendEmailAsync(string email, string subject, string message)
		{
			var resultMail = context.Mails.Where(x=>x.MailID==1).ToList().FirstOrDefault();

			var client = new SmtpClient(resultMail.SMTP,(int)resultMail.Port)
			{
				EnableSsl = true,
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential(resultMail.SenderMail,resultMail.SenderMailPassword)
			};

			return client.SendMailAsync(
				new MailMessage(from:resultMail.SenderMail,
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
