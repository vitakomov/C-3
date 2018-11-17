using System.Collections.Generic;
using PasswordDll;

namespace MailSender
{
	public static class Senders
	{
		public static Dictionary<string, string> SendersDictionary { get; } = new Dictionary<string, string>
		{
			{"qwe3@yandex.ru",  Encrypter.Deencrypt("1234l;i")},
			{"ewq@yandex.ru",  Encrypter.Deencrypt(";liq34tjk")}
		};
	}
}