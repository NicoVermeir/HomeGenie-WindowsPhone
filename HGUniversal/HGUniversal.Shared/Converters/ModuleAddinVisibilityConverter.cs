using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace HGUniversal.Converters
{
    public class ModuleAddinVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Visibility resvis = Visibility.Collapsed;
            string types = ":" + ((string)parameter) + ":";
            if (types.Contains(value.ToString()))
            {
                resvis = Visibility.Visible;
            }
            return resvis;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}