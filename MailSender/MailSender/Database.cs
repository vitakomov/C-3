using System.Linq;

namespace MailSender
{
	public static class DataBase
	{
		private static EmailsDataContext _emailsDataContext = new EmailsDataContext();

		public static IQueryable<Emails> Emails => from email in _emailsDataContext.Emails select email;

	}
}