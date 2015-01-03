using System;
using Windows.UI.Xaml.Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using HomeGenie.SDK.Contracts;

namespace HGUniversal.Converters
{
    public class ModuleIconUrlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (ViewModelBase.IsInDesignModeStatic)
                return "http://192.168.1.144/hg/html/pages/control/widgets/homegenie/generic/images/light_off.png";

            var settingsService = SimpleIoc.Default.GetInstance<ISettingsService>();

            return string.Format("http://{0}{1}",
                settingsService.GetValue<string>(Constants.ServerAddressSetting),
                value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}
