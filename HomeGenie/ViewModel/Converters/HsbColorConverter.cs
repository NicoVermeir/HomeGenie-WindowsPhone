using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using HomeGenie.SDK.Objects;
using HomeGenie.SDK.Utility;

namespace HomeGenie.ViewModel.Converters
{
    public class HsbColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = new Color();
            try
            {
                foreach (ModuleParameter p in (ObservableCollection<ModuleParameter>)value)
                {
                    if (p.Name == (string)parameter && p.Value != null && p.Value != "")
                    {
                        string[] colors = p.Value.Split(',');
                        if (colors.Length == 3)
                        {
                            double h = 0;
                            double s = 0;
                            double b = 0;
                            if (double.TryParse(colors[0], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out h) &&
                                double.TryParse(colors[1], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out s) &&
                                double.TryParse(colors[2], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out b))
                            {
                                HSBColor hsbcolor = new HSBColor();
                                hsbcolor.A = 255;
                                hsbcolor.H = h * 360d;
                                hsbcolor.S = s;
                                hsbcolor.B = b;
                                color = hsbcolor.ToColor();
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}