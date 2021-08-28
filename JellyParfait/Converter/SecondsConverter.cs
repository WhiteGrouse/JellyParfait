using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace JellyParfait.Converter
{
    [ValueConversion(typeof(int), typeof(string))]
    public class SecondsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var totalSeconds = (int)value;
            var time = TimeSpan.FromSeconds(totalSeconds);
            if (time.Hours > 0)
            {
                return time.ToString(@"hh\:mm\:ss");
            }
            else
            {
                return time.ToString(@"mm\:ss");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)TimeSpan.Parse(value as string).TotalSeconds;
        }
    }
}
