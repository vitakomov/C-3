using System.Windows;

namespace MailSender
{
	public partial class MainWindow : Window
	{
		public MainWindow() => InitializeComponent();

		private void TabSwitcherControlOnBack(object sender, RoutedEventArgs e)
		{
			if (MainTabControl.SelectedIndex == 0)
			{
				return;
			}

			MainTabControl.SelectedIndex--;
		}

		private void TabSwitcherControlOnForward(object sender, RoutedEventArgs e)
		{
			if (MainTabControl.SelectedIndex == MainTabControl.Items.Count-1)
			{
				return;
			}

			MainTabControl.SelectedIndex++;
		}
	}
}
