using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace HGUniversal.Converters
{
    public class IntToVisibilityConverter : IValueConverter
    {

        /// <exception cref="ArgumentException">TargetType must be Visibility</exception>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is int))
                throw new ArgumentException("Source must be of type int");

            if (targetType != typeof(Visibility))
                throw new ArgumentException("TargetType must be Visibility");

            int v = (int)value;

            if (v > 0)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

