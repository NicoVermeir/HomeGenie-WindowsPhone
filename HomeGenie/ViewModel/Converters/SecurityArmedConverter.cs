using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel.Converters
{
    public class SecurityArmedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
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

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}