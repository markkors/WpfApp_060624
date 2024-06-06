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

namespace WpfApp_060624.UserControls
{
    /// <summary>
    /// Interaction logic for PlayCardControl.xaml
    /// </summary>
    public partial class PlayCardControl : UserControl
    {


        public PlayCardControl()
        {
            InitializeComponent();
        }


        // Init the dependency properties
        public static readonly DependencyProperty SuitProperty = DependencyProperty.Register("Suit", typeof(string), typeof(PlayCardControl), new PropertyMetadata("Spades",OnSuitChanged));

       
        public static readonly DependencyProperty CardProperty = DependencyProperty.Register("Card", typeof(string), typeof(PlayCardControl), new PropertyMetadata("A",OnCardChanged));

       

        // Getters and Setters
        public string Suit
        {
            get { 
                return (string)GetValue(SuitProperty); 
            }
            set { 
                SetValue(SuitProperty, value);
                
            }
        }

        public string Card
        {
            get
            {
                return (string)GetValue(CardProperty);
            }
            set
            {
                SetValue(CardProperty, value);
                
            }
        }

        // Dependency Eventhandlers
        private static void OnSuitChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get the instance of the control
            PlayCardControl control = d as PlayCardControl;
            control.OnSetSuitChanged(e);
        }

        private void OnSetSuitChanged(DependencyPropertyChangedEventArgs e)
        {
            lblSuit.Content = e.NewValue.ToString();
            if(e.NewValue.ToString() == "♥" || e.NewValue.ToString() == "♦")
            {
                lblSuit.Foreground = Brushes.Red;
            }
            else
            {
                lblSuit.Foreground = Brushes.Black;
            }
        }



        private static void OnCardChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get the instance of the control
            PlayCardControl control = d as PlayCardControl;
            control.OnSetCardChanged(e);

        }

        private void OnSetCardChanged(DependencyPropertyChangedEventArgs e)
        {
            lblCard.Content = e.NewValue.ToString();
        }
    }
}
