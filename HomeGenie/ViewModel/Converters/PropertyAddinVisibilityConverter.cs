using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel.Converters
{
    public class PropertyAddinVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility resvis = Visibility.Collapsed;
            string types = ":" + ((string)parameter) + ":";
            try
            {
                bool hidesecuritylevel = false;
                foreach (ModuleParameter p in (ObservableCollection<ModuleParameter>)value)
                {
                    if (p.Name == (string)parameter && p.Value != null && p.Value != "")
                    {
                        resvis = Visibility.Visible;
                        //break;
                    }
                    else if (p.Name == "HomeGenie.SecurityArmed" && (string)parameter == "Status.Level")
                    {
                        hidesecuritylevel = true;
                    }
                }
                if (hidesecuritylevel) resvis = Visibility.Collapsed;
            }
            catch (Exception)
            {
            }
            return resvis;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}