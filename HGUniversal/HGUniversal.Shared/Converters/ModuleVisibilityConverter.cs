using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using HomeGenie.SDK.Objects;

namespace HGUniversal.Converters
{
    public class ModuleVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
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

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}