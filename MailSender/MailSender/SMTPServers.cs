using System.Collections.Generic;

namespace MailSender
{
	public static class SMTPServers
	{
		public static Dictionary<string, int> ServersDictionary { get; } = new Dictionary<string, int>
		{
			{"smtp.yandex.ru", 25 },
			{"smtp.mail.ru", 25 },
			{"smtp.gmail.com", 25 }
		};
	}
}