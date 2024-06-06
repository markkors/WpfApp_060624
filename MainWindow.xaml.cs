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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;


namespace WpfApp_060624
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cbMyComboBox.Items.Add("H");
            cbMyComboBox.Items.Add("D");
            cbMyComboBox.Items.Add("C");
            cbMyComboBox.Items.Add("S");
        }

       

       

        private void chkMyBox_Clicked(object sender, RoutedEventArgs e)
        {
           /* if (chkMyBox.IsChecked == true)
            {
                btnMyButton.Visibility = Visibility.Visible;
            }
            else
            {
                btnMyButton.Visibility = Visibility.Collapsed;
            }*/
            
        }
    }
}
