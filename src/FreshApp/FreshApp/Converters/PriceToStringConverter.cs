using System;
using System.Globalization;
using Xamarin.Forms;

namespace FreshApp.Converters
{
    public class PriceToStringConverter : IValueConverter
    {
        public bool IsCents { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (double)value;
            string stringVal = val.ToString("0.00", CultureInfo.InvariantCulture);
            string[] parts = stringVal.Split('.');
            int dolars = int.Parse(parts[0]);
            int cents = int.Parse(parts[1]);
            if (IsCents)
                return $".{cents}";
            else
                return dolars;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
