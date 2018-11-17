using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows;

namespace MailSender
{
	public class SendService
	{
		private readonly string _senderAddress;
		private readonly string _password;
		private readonly string _server;
		private readonly int _port;

		public string Subject { get; set; }
		public string Body { get; set; }

		public SendService(string senderAddress, string password, string server, int port)
		{
			_senderAddress = senderAddress;
			_password = password;
			_server = server;
			_port = port;

		}

		private void SendMail(string destinationAddress)
		{
			using (var msg = new MailMessage(_senderAddress, destinationAddress))
			{
				msg.Subject = Subject;
				msg.Body = Body;
				msg.IsBodyHtml = false;
				using (var client = new SmtpClient(_server, _port)
				{
					EnableSsl = true,
					Credentials = new NetworkCredential(_senderAddress, _password)
				})
					try
					{
						client.Send(msg);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка отправки сообщения: {ex.Message}");
					}
			}
		}
	}
}