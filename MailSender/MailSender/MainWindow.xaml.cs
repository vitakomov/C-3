using System;
using System.Linq;
using System.Windows;

namespace MailSender
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			object a = 1;
			object b = 1;

			Console.WriteLine(a==b);
			Console.WriteLine(a.Equals(b));
		}

		private void TabSwitcherControl_OnBack(object sender, RoutedEventArgs e)
		{
			if (MainTabControl.SelectedIndex == 0) return;
			MainTabControl.SelectedIndex--;
		}

		private void TabSwitcherControl_OnForward(object sender, RoutedEventArgs e)
		{
			if (MainTabControl.SelectedIndex == MainTabControl.Items.Count - 1) return;
			MainTabControl.SelectedIndex++;
		}

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			string strLogin = cbSenderSelect.Text;
			string strPassword = cbSenderSelect.SelectedValue.ToString();
			if (string.IsNullOrEmpty(strLogin))
			{
				MessageBox.Show("Выберите отправителя");
				return;
			}
			if (string.IsNullOrEmpty(strPassword))
			{
				MessageBox.Show("Укажите пароль отправителя");
				return;
			}
			EmailSendServiceClass emailSender = new EmailSendServiceClass(strLogin, strPassword);
			emailSender.SendMails((IQueryable<Emails>)dgEmails.ItemsSource);

		}
	}
}
