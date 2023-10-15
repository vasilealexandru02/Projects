using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TestXamarin.Converters
{
    public class FavoriteToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var carFavorited = (bool)value;
            if (carFavorited)
            {
                return Color.DarkGreen;
            }
            else
            {
                return Color.LightGray;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {

            }
            return null;
        }
    }
}
