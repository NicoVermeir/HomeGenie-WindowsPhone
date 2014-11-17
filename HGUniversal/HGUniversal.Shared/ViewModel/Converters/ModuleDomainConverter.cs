using System;
using Windows.UI.Xaml.Data;

namespace HGUniversal.ViewModel.Converters
{
    public class ModuleDomainConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string domain = (string)value;
            if (domain.IndexOf('.') > 0)
            {
                domain = domain.Substring(domain.LastIndexOf('.') + 1);
            }
            return domain;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}