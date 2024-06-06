using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp_060624.Converters
{
    public class LetterToSuitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string suit = "";
            switch (value.ToString())
            {
                case "0":
                    suit = "\u2665"; // Unicode voor harten
                    break;
                case "1":
                    suit = "\u2666"; // Unicode voor ruiten
                    break;
                case "2":
                    suit = "\u2660"; // Unicode voor schoppen
                    break;
                case "3":
                    suit = "\u2663"; // Unicode voor klaveren
                    break;
            }
            return suit;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string suit = "";
            switch (value.ToString())
            {
                case "Hearts":
                    suit = "H";
                    break;
                case "Diamonds":
                    suit = "D";
                    break;
                case "Spades":
                    suit = "S";
                    break;
                case "Clubs":
                    suit = "C";
                    break;
            }
            return suit;
        }
    }
}

