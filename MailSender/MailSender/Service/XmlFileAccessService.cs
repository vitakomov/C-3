﻿using System;
using System.Collections.ObjectModel;

namespace MailSender.Service
{
	public class XmlFileAccessService : IDataAccessService
	{
		public ObservableCollection<Emails> GetEmails() => throw new
			NotImplementedException();
		public int CreateEmail(Emails email) => throw new
			NotImplementedException();
	}
}