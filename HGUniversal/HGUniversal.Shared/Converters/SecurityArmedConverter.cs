using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Data;
using HomeGenie.SDK.Objects;

namespace HGUniversal.Converters
{
    public class SecurityArmedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool isarmed = false;
            bool isarming = false;
            string returnstring = "DISARMED";

            foreach (ModuleParameter p in (ObservableCollection<ModuleParameter>)value)
            {
                if (p.Name == "HomeGenie.SecurityArmed")
                {
                    isarmed = (p.Value == "1");
                }
                else if (p.Name == "Status.Level")
                {
                    isarming = (p.Value == "1");
                }
            }
            if (isarmed) returnstring = "ARMED";
            else if (isarming) returnstring = "ARMING...";

            return returnstring;
        }

    

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}