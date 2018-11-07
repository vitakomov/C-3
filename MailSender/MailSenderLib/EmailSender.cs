using System;
using System.Net;
using System.Net.Mail;

namespace MailSenderLib
{
    public class EmailSender
    {
	    private int _test;

		/// <summary>
		/// Метод отправляет письма
		/// </summary>
		/// <param name="strUser"></param>
		/// <param name="strPass"></param>
		/// <exception cref="SmtpException"></exception>
		[Obsolete("Устарело, используй что-то другое")]
		public void Send(string strUser, string strPass)
	    {
			const string from = "user@yandex.ru";
		    const string to = "user@gmail.com";

		    const string server = "smtp.yandex.ru";

		    var user = strUser;
		    var pass = strPass;

		    try
		    {
			    using (var message = new MailMessage(from, to, "Test message", "Test messae body"))
			    using (var client = new SmtpClient(server) { EnableSsl = true, Credentials = new NetworkCredential(user, pass) })
			    {
				    client.Send(message);
			    }
		    }
		    catch (SmtpException error)
		    {
			   throw new SmtpException(error.Message);
		    }
		}
    }
}
