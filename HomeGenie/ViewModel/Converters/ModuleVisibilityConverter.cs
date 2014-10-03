using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel.Converters
{
    public class ModuleVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                Module module = (Module)value;
                Visibility resvis = Visibility.Visible;
                if (module.DeviceType == Module.DeviceTypes.Program)
                {
                    if (module.Properties.Any(p => p.Name == "Widget.DisplayModule" && (p.Value == "" || p.Value == "homegenie/generic/program")))
                    {
                        resvis = Visibility.Collapsed;
                    }
                }
                return resvis;
            }
            catch
            {
                return Visibility.Collapsed;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}