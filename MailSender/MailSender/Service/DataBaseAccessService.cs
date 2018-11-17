﻿using System.Collections.ObjectModel;
using System.Linq;

namespace MailSender.Service
{
	public class DataBaseAccessService : IDataAccessService
	{
		private readonly EmailsDataContext _dataContext = new
			EmailsDataContext();
		public ObservableCollection<Emails> GetEmails() => new
			ObservableCollection<Emails>(_dataContext.Emails);
		public int CreateEmail(Emails email)
		{
			if (_dataContext.Emails.Contains(email)) return email.Id;
			_dataContext.Emails.InsertOnSubmit(email);
			_dataContext.SubmitChanges();
			return email.Id;
		}
	}
}
