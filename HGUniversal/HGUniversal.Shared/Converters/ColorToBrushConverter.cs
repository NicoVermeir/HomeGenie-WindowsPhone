using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace HGUniversal.Converters
{
    public class ColorToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var brush = value as SolidColorBrush;

            if (brush == null)
                return value;

            return brush.Color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var color = value as Color?;

            if (color == null)
                return value;

            return new SolidColorBrush(color.Value);
        }
    }
}
