using System;
using Windows.UI.Xaml.Data;
using HomeGenie.SDK.Objects;

namespace HGUniversal.Converters
{
    public class SecurityArmedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            ModuleParameter param = value as ModuleParameter;
            if (param == null) return value;

            bool isarmed = false;
            bool isarming = false;
            string returnstring = "DISARMED";

            if (param.Name == "HomeGenie.SecurityArmed")
            {
                isarmed = (param.Value == "1");
            }
            else if (param.Name == "Status.Level")
            {
                isarming = (param.Value == "1");
            }
            if (isarmed) returnstring = "ARMED";
            else if (isarming) returnstring = "ARMING...";

            return returnstring;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}