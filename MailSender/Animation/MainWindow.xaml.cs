using System.Windows;
using System.Windows.Controls;

namespace Animation
{
	public partial class MainWindow : Window
	{
		public MainWindow() => InitializeComponent();
		private void Cmd_Clicked(object sender, RoutedEventArgs e) => Lbl.Text = $"Selected button: {((Button)e.OriginalSource).Content}";
	}
}
