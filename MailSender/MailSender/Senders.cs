﻿using System.Collections.Generic;

namespace MailSender
{
	public static class Senders
	{
		public static Dictionary<string, string> SendersDictionary { get; } = new Dictionary<string, string>
		{
			{"qwe@ewq.ru", EncrypterDll.Encrypter.Encrypt("123")},
			{"qaz@zaq.ru", EncrypterDll.Encrypter.Encrypt("3241")}
		};
	}
}