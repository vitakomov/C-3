using System;
using System.Net;
using System.Windows;
using System.Net.Mail;
using MailSenderLib;

namespace MailSender
{
	partial class MainWindow : Window
    {
		internal MainWindow() => InitializeComponent();
		protected 
	    void Button_Click(object sender, RoutedEventArgs e)
	    {
		    try
		    {
			    var send = new EmailSender();
			    send.Send(UserNameTextBox.Text, PasswordEdit.Password);
		    }
		    catch (Exception exception)
		    {
			    //MessageBox.Show(error.Message, "При отправке сообщения возникла ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
			    var dlg = new MessageSendCompletedDlg(exception.StackTrace);
			    dlg.ShowDialog();
		    }

		    MyClass<int>.Test = 4;
		    MyClass<string>.Test = 4.ToString();
	    }
	}

	public class A {}

	internal class B : A // не может иметь более высокий уровень доступа чем базовый класс
	{
		public void NameMethod()
		{
			
		}
	} 
}

class MyClass <T>
{
	public static T Test;
}


