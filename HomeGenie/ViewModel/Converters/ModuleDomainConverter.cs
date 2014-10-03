using System;
using System.Globalization;
using System.Windows.Data;

namespace HomeGenie.ViewModel.Converters
{
    public class ModuleDomainConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string domain = (string)value;
            if (domain.IndexOf('.') > 0)
            {
                domain = domain.Substring(domain.LastIndexOf('.') + 1);
            }
            return domain;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}