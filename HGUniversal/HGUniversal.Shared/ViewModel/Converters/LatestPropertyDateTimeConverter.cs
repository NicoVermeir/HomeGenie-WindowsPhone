using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Data;
using HomeGenie.SDK.Objects;

namespace HGUniversal.ViewModel.Converters
{
    public class LatestPropertyDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string updated = "";
            try
            {
                DateTime lastdate = DateTime.MinValue;
                foreach (ModuleParameter p in (ObservableCollection<ModuleParameter>)value)
                {
                    if (p.UpdateTime > lastdate)
                    {
                        lastdate = p.UpdateTime;
                    }
                }
                if (lastdate != DateTime.MinValue)
                {
                    return lastdate.ToLocalTime().ToUniversalTime() + " " + lastdate.ToLocalTime().ToUniversalTime();
                }
            }
            catch (Exception)
            {
            }
            return updated;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}