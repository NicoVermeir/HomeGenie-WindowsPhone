using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel.Converters
{
    public class LatestPropertyDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
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
                    return lastdate.ToLocalTime().ToLongDateString() + " " + lastdate.ToLocalTime().ToLongTimeString();
                }
            }
            catch (Exception)
            {
            }
            return updated;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}