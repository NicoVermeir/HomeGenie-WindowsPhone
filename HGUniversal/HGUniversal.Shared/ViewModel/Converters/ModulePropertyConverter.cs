using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Data;
using HomeGenie.SDK.Objects;

namespace HGUniversal.ViewModel.Converters
{
    public class ModulePropertyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool addunitsymbol = false;
            object resval = null;
            try
            {
                string param = (string)parameter;
                if (param.EndsWith("+"))
                {
                    addunitsymbol = true;
                    param = param.TrimEnd('+');
                }
                foreach (ModuleParameter p in (ObservableCollection<ModuleParameter>)value)
                {
                    if (p.Name == param)
                    {
                        double val = 0;
                        if (double.TryParse(p.Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out val))
                        {
                            resval = Math.Round(val, 2);
                            if (addunitsymbol)
                            {
                                switch (p.Name)
                                {
                                    case "Sensor.Temperature":
                                        resval = resval.ToString() + " �C";
                                        break;
                                    case "Sensor.TemperatureF":
                                        resval = resval.ToString() + " F";
                                        break;
                                    case "Meter.Watts":
                                        resval = resval.ToString() + " W";
                                        break;
                                    case "Status.Level":
                                        resval = (double)resval * 100d;
                                        switch ((int)((double)resval))
                                        {
                                            case 0:
                                                resval = "OFF";
                                                break;
                                            case 100:
                                                resval = "ON";
                                                break;
                                            default:
                                                resval = resval.ToString() + " %";
                                                break;
                                        }
                                        break;
                                    case "Status.Battery":
                                    case "Sensor.Luminance":
                                    case "Sensor.Humidity":
                                        resval = resval.ToString() + " %";
                                        break;
                                }
                            }
                        }
                        else
                        {
                            resval = p.Value;
                        }
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
            return resval;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}