using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Window
    {
        public AddEdit(Dictionary<string, string> List,bool isNew)
        {
            InitializeComponent();
            TextList = List;
            this.isNew = isNew;
            Load();
        }
        bool isNew;
        private void Load()
        {
            gShow.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) });
            gShow.ColumnDefinitions.Add(new ColumnDefinition());
            foreach (var one in TextList)
            {
                gShow.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
                TextBlock tbName = new TextBlock() { Text = one.Key };
                gShow.SetFromGrid(tbName, Column: 0);
                
                TextBox tbxValue = new TextBox();
                var bind= BindingOperations.GetBinding(tbxValue, TextBox.TextProperty);
                bind.Path= new PropertyPath(nameof(one.Value));
                bind.Mode = BindingMode.TwoWay;
                tbxValue.SetBinding(TextBox.TextProperty, bind);
                gShow.SetFromGrid(tbxValue);
            }
        }


        public Dictionary<string,string> TextList;

        private void Close_Click(object sender, RoutedEventArgs e)
        { this.DialogResult = false; }
    }
}
