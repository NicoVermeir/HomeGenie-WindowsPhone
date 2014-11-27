using System;
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

            try
            {
                ModuleParameter param = value as ModuleParameter;
                if (param == null)
                    return Visibility.Collapsed;

                bool hidesecuritylevel = false;

                if (!string.IsNullOrWhiteSpace(param.Value))
                {
                    resvis = Visibility.Visible;
                }
                
                if (param.Name == "HomeGenie.SecurityArmed")
                {
                    hidesecuritylevel = true;
                }

                if (param.Name.Contains("ConfigureOptions"))
                    return Visibility.Collapsed;

                switch (param.Name)
                {
                    case "VirtualModule.ParentId":
                    case "Widget.DisplayModule":
                        return Visibility.Collapsed;
                }
                if (hidesecuritylevel) resvis = Visibility.Collapsed;
            }
            catch (Exception)
            {
                return Visibility.Collapsed;
            }
            return resvis;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}