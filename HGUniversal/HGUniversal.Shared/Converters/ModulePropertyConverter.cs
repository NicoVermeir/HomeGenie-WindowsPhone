using System;
using Windows.UI.Xaml.Data;
using HomeGenie.SDK.Objects;

namespace HGUniversal.Converters
{
    public class ModulePropertyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                ModuleParameter param = value as ModuleParameter;
                if (param == null)
                    return value;

                double val;

                if (double.TryParse(param.Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out val))
                {
                    val = Math.Round(val, 2);
                    param.Value = val.ToString();

                    switch (param.Name)
                    {
                        case "Sensor.Temperature":
                            param.Value = param.Value + " °C";
                            break;
                        case "Sensor.TemperatureF":
                            param.Value = param.Value + " F";
                            break;
                        case "Meter.Watts":
                            param.Value = param.Value + " W";
                            break;
                        case "Status.Level":
                            int level = (int) (val*100d);

                            switch (level)
                            {
                                case 0:
                                    param.Value = "OFF";
                                    break;
                                case 100:
                                    param.Value = "ON";
                                    break;
                                default:
                                    param.Value = param.Value.ToString() + " %";
                                    break;
                            }
                            break;
                        case "Status.Battery":
                        case "Sensor.Luminance":
                        case "Sensor.Humidity":
                            param.Value = param.Value.ToString() + " %";
                            break;

                    }
                }
                else
                {
                    return param;
                }
            }
            catch (Exception)
            {
                return value;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}