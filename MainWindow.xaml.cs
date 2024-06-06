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
using WpfApp_060624.UserControls;
using System.ComponentModel;


namespace WpfApp_060624
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        // implement the INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int _suit;
        public MainWindow()
        {
            InitializeComponent();
            cbMyComboBox.Items.Add("H");
            cbMyComboBox.Items.Add("D");
            cbMyComboBox.Items.Add("C");
            cbMyComboBox.Items.Add("S");
            this.DataContext = this;
            Suit = 0; // default hearts
        }



        public int Suit { 
            get 
            {
                return _suit;
            } 
        set {
                _suit = value;
                OnPropertyChanged("Suit");
                
            } 
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

        private void cbMyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int idx = comboBox.SelectedIndex;
            Suit = idx;
        }
    }
}
