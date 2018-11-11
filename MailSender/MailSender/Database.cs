using System.Linq;

namespace MailSender
{
	internal static class Database
	{
		private static readonly EmailsDataContext _emailsDataContext = new
			EmailsDataContext();
		public static IQueryable<Emails> Emails => from mail in
				_emailsDataContext.Emails
			select mail;
	}
}