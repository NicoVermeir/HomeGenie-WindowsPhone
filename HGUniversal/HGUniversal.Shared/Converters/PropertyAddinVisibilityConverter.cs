using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using HomeGenie.SDK.Objects;

namespace HGUniversal.Converters
{
    public class PropertyAddinVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var resvis = Visibility.Collapsed;
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

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}