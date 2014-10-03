using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HomeGenie.ViewModel.Converters
{
    public class ModuleAddinVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility resvis = Visibility.Collapsed;
            string types = ":" + ((string)parameter) + ":";
            if (types.Contains(value.ToString()))
            {
                resvis = Visibility.Visible;
            }
            return resvis;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}