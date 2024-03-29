﻿using BlogWebSite_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_BussinessLayer.Service
{
	public interface IEmailService:IGenericService<CommunicationModel>
	{
		Task SendEmailAsync(string email, string subject, string message);
	}
}
