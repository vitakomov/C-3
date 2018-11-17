using System.Windows;
using System.Windows.Controls;
namespace TabSwitcher
{
    public partial class TabSwitcherControl : UserControl
    {
		public TabSwitcherControl() => InitializeComponent();

	    public Button BackwardButton => BackvardButton;
	    public Button ForwardButton => ForvardButton;


		public event RoutedEventHandler Back;
	    public event RoutedEventHandler Forward;

	    private void BackvardButtonClick(object sender, RoutedEventArgs e) => Back?.Invoke(this, new RoutedEventArgs());
	    private void ForvardButtonClick(object sender, RoutedEventArgs e) => Forward?.Invoke(this, new RoutedEventArgs());
	}
}
