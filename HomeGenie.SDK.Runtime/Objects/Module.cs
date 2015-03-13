using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using Windows.UI.Xaml.Media.Imaging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HomeGenie.SDK.Objects
{
    public class Module : Data
    {
        public string Description { get; set; }

        // location in actual physical Control-topology
        public string Domain { get; set; } 

        public string Address { get; set; }

        public string RoutingNode { get; set; } // "<ip>:<port>" || ""

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetField(ref _name, value, "Name");
            }
        }

        private DeviceTypes _devicetype;
        [JsonConverter(typeof(StringEnumConverter))]
        public DeviceTypes DeviceType
        {
            get
            {
                return _devicetype;
            }
            set
            {
                if (SetField(ref _devicetype, value, "DeviceType"))
                {
                    OnPropertyChanged("IconUrl");                    
                }
            }
        } //will indicate actual device (lamp, fan, dimmer light, etc.)

        private ObservableCollection<ModuleParameter> _properties;
        public ObservableCollection<ModuleParameter> Properties
        {
            get
            {
                return _properties;
            }
            set
            {
                SetField(ref _properties, value, "Properties");
                OnPropertyChanged("IconUrl");
            }
        }

        public string IconUrl
        {
            get
            {
                //
                // collects module fields from module.Properties
                //
                double level = 0;
                string statussuffix = "";
                string widget = "";
                double doorwindow = 0;
                bool isCamera;

                try
                {
                    foreach (ModuleParameter p in Properties)
                    {
                        switch (p.Name)
                        {
                            case "Status.Level":
                                double.TryParse(p.Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out level);
                                break;
                            case "Widget.DisplayModule":
                                widget = p.Value;
                                break;
                            case "Sensor.DoorWindow":
                                double.TryParse(p.Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out doorwindow);
                                break;
                            case "IpCamera.ImageURL":
                                DeviceType = DeviceTypes.IpCamera;
                                break;
                        }
                    }
                    //
                    if (level != 0D || doorwindow != 0D)
                    {
                        statussuffix = "on";
                    }
                    else
                    {
                        statussuffix = "off";
                    }
                }
                // ReSharper disable once EmptyGeneralCatchClause
                catch
                {
                }


                string imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/program.png";

                if (widget != "")
                {
                    switch (widget)
                    {
                        case "weather/earthtools/sundata":
                            imageurl = "/hg/html/pages/control/widgets/weather/earthtools/images/earthtools.png";
                            break;
                        case "weather/wunderground/conditions":
                            ModuleParameter  weathericon = Properties.FirstOrDefault(mp => mp.Name == "Conditions.IconUrl"); 
                            if (weathericon != null)
                            {
                                string fname = weathericon.Value.Substring(weathericon.Value.LastIndexOf('/') + 1);
                                fname = fname.Replace(".gif", "");
                                if (fname.StartsWith("nt_"))
                                {
                                    fname = "/Assets/WeatherIcons/night/" + fname.Replace("nt_", "") + ".png";
                                }
                                else
                                {
                                    fname = "/Assets/WeatherIcons/day/" + fname + ".png";
                                }
                                imageurl = fname;
                            }
                            break;
                        case "homegenie/generic/link":
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/link.png";
                            break;
                        case "homegenie/generic/sensor":
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/sensor.png";
                            break;
                        case "homegenie/generic/doorwindow":
                            if (level != 0 || doorwindow != 0)
                                imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/door_open.png";
                            else
                                imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/door_closed.png";
                            break;
                        case "homegenie/generic/siren":
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/siren.png";
                            break;
                        case "homegenie/generic/temperature":
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/temperature.png";
                            break;
                        case "homegenie/generic/securitysystem":
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/securitysystem.png";
                            break;
                        case "homegenie/generic/switch":
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/socket_" + statussuffix + ".png";
                            break;
                        case "homegenie/generic/light":
                        case "homegenie/generic/dimmer":
                        case "homegenie/generic/colorlight":
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/light_" + statussuffix + ".png";
                            break;
                        case "homegenie/generic/camerainput":
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/camera.png";
                            break;
                    }
                }
                else
                {
                    // no widget specified, device type fallback
                    var type = DeviceType;
                    switch (type)
                    {
                        case DeviceTypes.Light:
                        case DeviceTypes.Dimmer:
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/light_" + statussuffix + ".png";
                            break;
                        case DeviceTypes.Switch:
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/socket_" + statussuffix + ".png";
                            break;
                        case DeviceTypes.Sensor:
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/sensor.png";
                            break;
                        case DeviceTypes.DoorWindow:
                            if (statussuffix == "on") statussuffix = "open"; else statussuffix = "closed";
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/door_" + statussuffix + ".png";
                            break;
                        case DeviceTypes.Temperature:
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/temperature.png";
                            break;
                        case DeviceTypes.Siren:
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/siren.png";
                            break;
                        case DeviceTypes.Shutter:
                            statussuffix = statussuffix == "on" ? "open" : "closed";
                            imageurl = "/hg/html/pages/control/widgets/homegenie/generic/images/shutters_" + statussuffix + ".png";
                            break;
                    }
                }
                return imageurl;
            }
        }

        public Module()
        {
            Name = "";
            Properties = new ObservableCollection<ModuleParameter>();
            RoutingNode = "";
        }

        public enum DeviceTypes
        {
            Generic = -1,
            ColorLight,
            Program,
            Switch,
            Light,
            Dimmer,
            Sensor,
            Temperature,
            Siren,
            Fan,
            Thermostat,
            Shutter,
            DoorWindow,
            MediaTransmitter
            //siren, alarm, motion sensor, door sensor, thermal sensor, etc.
            ,
            IpCamera
        }
    }
}