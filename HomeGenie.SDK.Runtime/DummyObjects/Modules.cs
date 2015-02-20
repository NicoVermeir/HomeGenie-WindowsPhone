namespace HomeGenie.SDK.DummyObjects
{
    public class Modules
    {
        public static string ModuleJson = @"[{
   ""Name"": ""Security Alarm System"",
   ""Description"": """",
   ""DeviceType"": ""Program"",
   ""Domain"": ""HomeAutomation.HomeGenie.Automation"",
   ""Address"": ""90"",
   ""Properties"": [ 
       {
           ""Name"": ""ConfigureOptions.Email.Recipients"",
           ""Description"": ""3. Comma separated list of recipients e-mails for alarm notifications"",
           ""Value"": ""xxxxxxxxx,xxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""ConfigureOptions.System.ArmDelay"",
           ""Description"": ""1. Arm Delay (seconds)"",
           ""Value"": ""30"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""ConfigureOptions.System.SirenMaxTime"",
           ""Description"": ""2. Sirens Max Time (seconds, 0=infinite)"",
           ""Value"": ""600"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""ConfigureOptions.Trigger.ArmedProgram"",
           ""Description"": ""4. Program to run when armed"",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 20:41:09Z""
       },
       {
           ""Name"": ""ConfigureOptions.Trigger.DisarmedProgram"",
           ""Description"": ""5. Program to run when disarmed"",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 20:41:09Z""
       },
       {
           ""Name"": ""ConfigureOptions.Trigger.TriggeredProgram"",
           ""Description"": ""6. Program to run when triggered"",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 20:41:09Z""
       },
       {
           ""Name"": ""HomeGenie.SecurityArmed"",
           ""Description"": """",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:41:11Z""
       },
       {
           ""Name"": ""HomeGenie.SecurityTriggered"",
           ""Description"": """",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:41:11Z""
       },
       {
           ""Name"": ""HomeGenie.SecurityTriggerSource"",
           ""Description"": """",
           ""Value"": ""DetectSalon Status.Level (HomeAutomation.ZWave.31)"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""Program.Status"",
           ""Description"": """",
           ""Value"": ""Running"",
           ""UpdateTime"": ""2015-02-09 20:41:11Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:41:11Z""
       },
       {
           ""Name"": ""VirtualModule.ParentId"",
           ""Description"": """",
           ""Value"": ""90"",
           ""UpdateTime"": ""2015-02-09 21:31:50Z""
       },
       {
           ""Name"": ""Widget.DisplayModule"",
           ""Description"": """",
           ""Value"": ""homegenie/generic/securitysystem"",
           ""UpdateTime"": ""2014-04-11 19:26:31Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Sensor 1"",
   ""Description"": ""ZWave Sensor"",
   ""DeviceType"": ""Sensor"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.SecuritySensor"",
           ""Description"": """",
           ""Value"": ""On"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 10:33:56Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""MobileNotification.SendChanges"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:16:36Z""
       },
       {
           ""Name"": ""Sensor.Humidity"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 21:57:05Z""
       },
       {
           ""Name"": ""Sensor.Luminance"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:57:05Z""
       },
       {
           ""Name"": ""Sensor.Temperature"",
           ""Description"": """",
           ""Value"": ""xx.x"",
           ""UpdateTime"": ""2015-02-09 21:57:05Z""
       },
       {
           ""Name"": ""Status.Battery"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:57:05Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:53:39Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:53:39Z""
       },
       {
           ""Name"": ""ZWaveNode.Battery"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:57:05Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Aeon.MultiSensor"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""0086:0002:0005"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.111"",
           ""Description"": """",
           ""Value"": ""xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.112"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.113"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.4"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpInterval"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Sensor 2"",
   ""Description"": ""ZWave Multilevel Switch"",
   ""DeviceType"": ""Sensor"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.SecuritySensor"",
           ""Description"": """",
           ""Value"": ""On"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 10:34:01Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""Sensor.Alarm"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""Sensor.Generic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:50:10Z""
       },
       {
           ""Name"": ""Sensor.Luminance"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 22:02:10Z""
       },
       {
           ""Name"": ""Sensor.Temperature"",
           ""Description"": """",
           ""Value"": ""xx.x"",
           ""UpdateTime"": ""2015-02-09 22:00:19Z""
       },
       {
           ""Name"": ""Status.Battery"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:50:10Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.1"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.2"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.3"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Count"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Max"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:50:10Z""
       },
       {
           ""Name"": ""ZWaveNode.Battery"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Fibaro.MotionSensor"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""010F:0800:1001"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-12 20:22:07Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-12 20:22:07Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""04 20 01 30 84 85 80 8F 56 72 86 70 8E 31 xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""ipcamera 1"",
   ""Description"": """",
   ""DeviceType"": ""Sensor"",
   ""Domain"": ""Media.IpCamera"",
   ""Address"": ""x"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.SecuritySensor"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-15 12:57:47Z""
       },
       {
           ""Name"": ""Image.URL"",
           ""Description"": """",
           ""Value"": ""/api/Media.IpCamera/1/Camera.GetPicture/"",
           ""UpdateTime"": ""2015-02-09 20:41:09Z""
       },
       {
           ""Name"": ""IpCamera.ImageURL"",
           ""Description"": """",
           ""Value"": ""http://xx.xx.xx.xx/image/jpeg.cgi"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""IpCamera.Password"",
           ""Description"": """",
           ""Value"": ""xxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""IpCamera.Username"",
           ""Description"": """",
           ""Value"": ""xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-15 12:57:47Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""VirtualModule.ParentId"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 21:31:50Z""
       },
       {
           ""Name"": ""Widget.DisplayModule"",
           ""Description"": """",
           ""Value"": ""homegenie/generic/camerainput"",
           ""UpdateTime"": ""2015-02-09 20:41:06Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""shutter 1"",
   ""Description"": ""ZWave Multilevel Switch"",
   ""DeviceType"": ""Shutter"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.ScheduleControl"",
           ""Description"": """",
           ""Value"": ""On"",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOff"",
           ""Description"": """",
           ""Value"": ""xxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOn"",
           ""Description"": """",
           ""Value"": ""xxxxxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""HomeGenie.ZWaveLevelPoll"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-07 09:53:44Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""xx.xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""Meter.KilowattHour"",
           ""Description"": """",
           ""Value"": ""xx.xx"",
           ""UpdateTime"": ""2015-02-09 21:15:13Z""
       },
       {
           ""Name"": ""Meter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Sensor.Power"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:15:23Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 22:05:36Z""
       },
       {
           ""Name"": ""TimeTable.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""TimeTable.Holiday"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""TimeTable.Special"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""TimeTable.Weekend"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""TimeTable.Workday"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:15:31Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.3"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Count"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Max"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 22:05:36Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Generic.Dimmer"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""xxxx:xxxx:xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.1"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.10"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.12"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.13"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.14"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.18"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.22"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.29"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.30"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.32"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.33"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.40"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.42"",
           ""Description"": """",
           ""Value"": ""xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.43"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""shutter 3"",
   ""Description"": ""ZWave Multilevel Switch"",
   ""DeviceType"": ""Shutter"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.ScheduleControl"",
           ""Description"": """",
           ""Value"": ""On"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOff"",
           ""Description"": """",
           ""Value"": ""xxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOn"",
           ""Description"": """",
           ""Value"": ""xxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.ZWaveLevelPoll"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-24 08:44:26Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-07 09:53:51Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""xx.xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Meter.KilowattHour"",
           ""Description"": """",
           ""Value"": ""xx.xx"",
           ""UpdateTime"": ""2015-02-09 21:59:48Z""
       },
       {
           ""Name"": ""Meter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Sensor.Generic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Sensor.Power"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:15:24Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.1"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2014-11-14 14:02:11Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.3"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Count"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Max"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Generic.Dimmer"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""xxxx:xxxx:xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-14 21:21:16Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.1"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-14 21:21:16Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 21:15:32Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.10"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.14"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.29"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.40"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.42"",
           ""Description"": """",
           ""Value"": ""xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.43"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:15:32Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""shutter 4"",
   ""Description"": ""ZWave Multilevel Switch"",
   ""DeviceType"": ""Shutter"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.ScheduleControl"",
           ""Description"": """",
           ""Value"": ""On"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOff"",
           ""Description"": """",
           ""Value"": ""xxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOn"",
           ""Description"": """",
           ""Value"": ""xxxxxxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.ZWaveLevelPoll"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-24 08:44:29Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-07 09:53:57Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""xx.xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Meter.KilowattHour"",
           ""Description"": """",
           ""Value"": ""xx.xx"",
           ""UpdateTime"": ""2015-02-09 21:33:26Z""
       },
       {
           ""Name"": ""Meter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Sensor.Power"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:15:02Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Generic.Dimmer"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""xxxx:xxxx:xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-15 13:18:24Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.1"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-15 13:18:24Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.14"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.29"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.40"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.43"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Light 1"",
   ""Description"": """",
   ""DeviceType"": ""Light"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xxxx.xx"",
   ""Properties"": [ 
       {
           ""Name"": ""Adv_SmartLights.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 14:01:21Z""
       },
       {
           ""Name"": ""Adv_SmartLights.MotionDelayStartWhenMotionStops"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Adv_SmartLights.MotionDetector"",
           ""Description"": """",
           ""Value"": ""xxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Adv_SmartLights.Switch"",
           ""Description"": """",
           ""Value"": ""xxxxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Adv_SmartLights.TurnoffTimeout"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""EnergyManagement.EnergySavingMode"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-14 22:29:20Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleControl"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOff"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOn"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""HomeGenie.SecurityAlarm"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.CheckLuminosity"",
           ""Description"": """",
           ""Value"": ""xxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.Enable"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.LastEvent"",
           ""Description"": """",
           ""Value"": ""xxxxxxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 21:48:23Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.OnMotionDetect"",
           ""Description"": """",
           ""Value"": ""xxxxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.SwitchOffTimeout"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.ZWaveLevelPoll"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-14 22:33:44Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 22:02:11Z""
       },
       {
           ""Name"": ""Stuck_Module_Check.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 14:01:21Z""
       },
       {
           ""Name"": ""Stuck_Module_Check.StuckModuleTimeout"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 14:01:21Z""
       },
       {
           ""Name"": ""TimeTable.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""TimeTable.Holiday"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""TimeTable.Special"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""TimeTable.Weekend"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""TimeTable.Workday"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 05:35:21Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""VirtualModule.ParentId"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2014-12-14 22:24:12Z""
       },
       {
           ""Name"": ""Widget.DisplayModule"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-16 05:01:35Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-14 22:24:42Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-14 22:24:42Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Light 2"",
   ""Description"": """",
   ""DeviceType"": ""Light"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx.xx"",
   ""Properties"": [ 
       {
           ""Name"": ""Adv_SmartLights.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 19:33:00Z""
       },
       {
           ""Name"": ""Adv_SmartLights.MotionDelayStartWhenMotionStops"",
           ""Description"": """",
           ""Value"": ""xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Adv_SmartLights.MotionDetector"",
           ""Description"": """",
           ""Value"": ""xxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Adv_SmartLights.Switch"",
           ""Description"": """",
           ""Value"": ""xxxxxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Adv_SmartLights.TurnoffTimeout"",
           ""Description"": """",
           ""Value"": ""xxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""EnergyManagement.EnergySavingMode"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-14 22:29:25Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleControl"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOff"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOn"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""HomeGenie.SecurityAlarm"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.CheckLuminosity"",
           ""Description"": """",
           ""Value"": ""DetectSalon3"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.OnMotionDetect"",
           ""Description"": """",
           ""Value"": ""xxxxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.SmartLights.SwitchOffTimeout"",
           ""Description"": """",
           ""Value"": ""xxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""HomeGenie.ZWaveLevelPoll"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-14 22:33:48Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Stuck_Module_Check.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 19:33:00Z""
       },
       {
           ""Name"": ""Stuck_Module_Check.StuckModuleTimeout"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 19:33:00Z""
       },
       {
           ""Name"": ""TimeTable.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""TimeTable.Holiday"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""TimeTable.Special"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""TimeTable.Weekend"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""TimeTable.Workday"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-06 22:50:53Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""VirtualModule.ParentId"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2014-12-14 22:24:12Z""
       },
       {
           ""Name"": ""Widget.DisplayModule"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-16 05:02:00Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-14 22:24:42Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-12-14 22:24:42Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""DoorWindow 1"",
   ""Description"": ""ZWave Sensor"",
   ""DeviceType"": ""DoorWindow"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.SecuritySensor"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 10:34:16Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""MobileNotification.SendChanges"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:19:19Z""
       },
       {
           ""Name"": ""Sensor.Alarm"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""Status.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Generic.Sensor"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""xxxx:xxxx:xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:32:18Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""sensor 5"",
   ""Description"": ""Binary Sensor"",
   ""DeviceType"": ""Sensor"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.SecuritySensor"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-07 15:36:58Z""
       },
       {
           ""Name"": ""Sensor.Humidity"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 22:02:27Z""
       },
       {
           ""Name"": ""Sensor.Luminance"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 22:02:27Z""
       },
       {
           ""Name"": ""Sensor.Temperature"",
           ""Description"": """",
           ""Value"": ""xx.xx"",
           ""UpdateTime"": ""2015-02-09 22:02:27Z""
       },
       {
           ""Name"": ""Status.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 22:02:27Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:42:58Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:42:58Z""
       },
       {
           ""Name"": ""ZWaveNode.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 22:02:27Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 20:41:10Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 20:41:10Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Siren 1"",
   ""Description"": ""ZWave Switch"",
   ""DeviceType"": ""Siren"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""x"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.SecurityAlarm"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 10:34:23Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""MobileNotification.SendChanges"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:21:25Z""
       },
       {
           ""Name"": ""Status.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""ZWaveNode.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Generic.Switch"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""xxxx:xxxx:xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:54Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Siren 2"",
   ""Description"": ""ZWave Multilevel Switch"",
   ""DeviceType"": ""Siren"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.SecurityAlarm"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-01-04 10:34:26Z""
       },
       {
           ""Name"": ""LastEvent.LastEvent"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""MobileNotification.SendChanges"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:21:58Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Basic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Generic.Dimmer"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""xxxx:xxxx:xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-27 19:31:11Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Weather Underground"",
   ""Description"": """",
   ""DeviceType"": ""Program"",
   ""Domain"": ""HomeAutomation.HomeGenie.Automation"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""Astronomy.Sunrise"",
           ""Description"": """",
           ""Value"": ""08:01"",
           ""UpdateTime"": ""2015-02-09 21:42:31Z""
       },
       {
           ""Name"": ""Astronomy.Sunset"",
           ""Description"": """",
           ""Value"": ""18:16"",
           ""UpdateTime"": ""2015-02-09 21:42:31Z""
       },
       {
           ""Name"": ""Conditions.City"",
           ""Description"": """",
           ""Value"": ""xxxxx"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.Country"",
           ""Description"": """",
           ""Value"": ""FR"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.CountryCode"",
           ""Description"": """",
           ""Value"": ""FR"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.Description"",
           ""Description"": """",
           ""Value"": ""Ciel dégagé"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.DisplayCelsius"",
           ""Description"": """",
           ""Value"": ""TRUE"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.DisplayLocation"",
           ""Description"": """",
           ""Value"": ""xxxxxxx, France"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.FeelsLikeC"",
           ""Description"": """",
           ""Value"": ""-2"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.FeelsLikeF"",
           ""Description"": """",
           ""Value"": ""29"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.Day"",
           ""Description"": """",
           ""Value"": ""10"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.Description"",
           ""Description"": """",
           ""Value"": ""Ciel dégagé"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.IconUrl"",
           ""Description"": """",
           ""Value"": ""http://icons.wxug.com/i/c/e/clear.gif"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.Month"",
           ""Description"": """",
           ""Value"": ""février"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.TemperatureC.High"",
           ""Description"": """",
           ""Value"": ""11"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.TemperatureC.Low"",
           ""Description"": """",
           ""Value"": ""-2"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.TemperatureF.High"",
           ""Description"": """",
           ""Value"": ""52"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.TemperatureF.Low"",
           ""Description"": """",
           ""Value"": ""29"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.Weekday"",
           ""Description"": """",
           ""Value"": ""mardi"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.1.Year"",
           ""Description"": """",
           ""Value"": ""2015"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.Day"",
           ""Description"": """",
           ""Value"": ""11"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.Description"",
           ""Description"": """",
           ""Value"": ""Ciel dégagé"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.IconUrl"",
           ""Description"": """",
           ""Value"": ""http://icons.wxug.com/i/c/e/clear.gif"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.Month"",
           ""Description"": """",
           ""Value"": ""février"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.TemperatureC.High"",
           ""Description"": """",
           ""Value"": ""13"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.TemperatureC.Low"",
           ""Description"": """",
           ""Value"": ""3"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.TemperatureF.High"",
           ""Description"": """",
           ""Value"": ""55"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.TemperatureF.Low"",
           ""Description"": """",
           ""Value"": ""38"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.Weekday"",
           ""Description"": """",
           ""Value"": ""mercredi"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.2.Year"",
           ""Description"": """",
           ""Value"": ""2015"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.Day"",
           ""Description"": """",
           ""Value"": ""12"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.Description"",
           ""Description"": """",
           ""Value"": ""Partiellement nuageux"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.IconUrl"",
           ""Description"": """",
           ""Value"": ""http://icons.wxug.com/i/c/e/partlycloudy.gif"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.Month"",
           ""Description"": """",
           ""Value"": ""février"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.TemperatureC.High"",
           ""Description"": """",
           ""Value"": ""13"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.TemperatureC.Low"",
           ""Description"": """",
           ""Value"": ""4"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.TemperatureF.High"",
           ""Description"": """",
           ""Value"": ""56"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.TemperatureF.Low"",
           ""Description"": """",
           ""Value"": ""39"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.Weekday"",
           ""Description"": """",
           ""Value"": ""jeudi"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.Forecast.3.Year"",
           ""Description"": """",
           ""Value"": ""2015"",
           ""UpdateTime"": ""2015-02-09 21:42:33Z""
       },
       {
           ""Name"": ""Conditions.IconUrl"",
           ""Description"": """",
           ""Value"": ""http://icons.wxug.com/i/c/e/nt_clear.gif"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.LastUpdated"",
           ""Description"": """",
           ""Value"": ""Last Updated on février 9, 22:30 CET"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.PrecipitationHourMetric"",
           ""Description"": """",
           ""Value"": ""--"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.PressureMb"",
           ""Description"": """",
           ""Value"": ""1027"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.Status"",
           ""Description"": """",
           ""Value"": ""clear"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.TemperatureC"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.TemperatureF"",
           ""Description"": """",
           ""Value"": ""34"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.UV"",
           ""Description"": """",
           ""Value"": ""-1"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.WindDirection"",
           ""Description"": """",
           ""Value"": ""SSW"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""Conditions.WindKph"",
           ""Description"": """",
           ""Value"": ""9"",
           ""UpdateTime"": ""2015-02-09 21:42:32Z""
       },
       {
           ""Name"": ""ConfigureOptions.ApiKey"",
           ""Description"": ""Weather Underground Key"",
           ""Value"": ""2c4266d6e375328b"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""ConfigureOptions.InputDisplayCelsius"",
           ""Description"": ""Display Temperature in degrees Celsius - TRUE or FALSE"",
           ""Value"": ""TRUE"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""ConfigureOptions.Language"",
           ""Description"": ""Language"",
           ""Value"": ""FR"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""ConfigureOptions.Location"",
           ""Description"": ""City name"",
           ""Value"": ""Toulouse"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""ConfigureOptions.UpdateInterval"",
           ""Description"": ""Update interval (minutes)"",
           ""Value"": ""30"",
           ""UpdateTime"": ""2015-02-09 20:40:52Z""
       },
       {
           ""Name"": ""Program.Status"",
           ""Description"": """",
           ""Value"": ""Running"",
           ""UpdateTime"": ""2015-02-09 20:41:13Z""
       },
       {
           ""Name"": ""VirtualModule.ParentId"",
           ""Description"": """",
           ""Value"": ""34"",
           ""UpdateTime"": ""2015-02-09 21:31:50Z""
       },
       {
           ""Name"": ""Widget.DisplayModule"",
           ""Description"": """",
           ""Value"": ""weather/wunderground/conditions"",
           ""UpdateTime"": ""2014-04-11 19:26:31Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""jkUtils - Solar Altitude"",
   ""Description"": """",
   ""DeviceType"": ""Program"",
   ""Domain"": ""HomeAutomation.HomeGenie.Automation"",
   ""Address"": ""501"",
   ""Properties"": [ 
       {
           ""Name"": ""ConfigureOptions.jkUtils.SolarAltitude.Color"",
           ""Description"": ""Custom Color (HUE Value)"",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.jkUtils.SolarAltitude.Label"",
           ""Description"": ""Custom Label"",
           ""Value"": ""xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.jkUtils.SolarAltitude.Latitude"",
           ""Description"": ""Location: Latitude"",
           ""Value"": ""xxx.xxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.jkUtils.SolarAltitude.Longitude"",
           ""Description"": ""Location: Longitude"",
           ""Value"": ""xxx.xxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.jkUtils.SolarAltitude.Timeformat"",
           ""Description"": ""Custom Timeformat (TRUE = use AM/PM Format, FALSE = use 24h Format)"",
           ""Value"": ""FALSE"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.jkUtils.SolarAltitude.Zoom"",
           ""Description"": ""Custom Zoom"",
           ""Value"": ""100%"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Day.Noon"",
           ""Description"": """",
           ""Value"": ""13:10"",
           ""UpdateTime"": ""2015-02-09 20:41:23Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Day.Start"",
           ""Description"": """",
           ""Value"": ""06:26"",
           ""UpdateTime"": ""2015-02-09 20:41:23Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Astronomical.End"",
           ""Description"": """",
           ""Value"": ""19:52"",
           ""UpdateTime"": ""2015-02-09 20:41:26Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Astronomical.Start"",
           ""Description"": """",
           ""Value"": ""19:20"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Civil.End"",
           ""Description"": """",
           ""Value"": ""18:45"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Civil.Start"",
           ""Description"": """",
           ""Value"": ""18:16"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.GoldenHour.End"",
           ""Description"": """",
           ""Value"": ""18:12"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.GoldenHour.Start"",
           ""Description"": """",
           ""Value"": ""17:35"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Nautical.End"",
           ""Description"": """",
           ""Value"": ""19:19"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Nautical.Start"",
           ""Description"": """",
           ""Value"": ""18:46"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Night.Start"",
           ""Description"": """",
           ""Value"": ""19:53"",
           ""UpdateTime"": ""2015-02-09 20:41:26Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Sunset.End"",
           ""Description"": """",
           ""Value"": ""18:15"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Evening.Sunset.Start"",
           ""Description"": """",
           ""Value"": ""18:13"",
           ""UpdateTime"": ""2015-02-09 20:41:25Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Label"",
           ""Description"": """",
           ""Value"": ""Toulouse"",
           ""UpdateTime"": ""2015-02-09 20:41:22Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.LastUpdated"",
           ""Description"": """",
           ""Value"": ""21:41"",
           ""UpdateTime"": ""2015-02-09 20:41:26Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Latitude"",
           ""Description"": """",
           ""Value"": ""43.550406"",
           ""UpdateTime"": ""2015-02-09 20:41:22Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Longitude"",
           ""Description"": """",
           ""Value"": ""1.389378"",
           ""UpdateTime"": ""2015-02-09 20:41:22Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Moon.Angle"",
           ""Description"": """",
           ""Value"": ""1.92966537853102"",
           ""UpdateTime"": ""2015-02-09 20:41:26Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Moon.Fraction"",
           ""Description"": """",
           ""Value"": ""0.712793501036931"",
           ""UpdateTime"": ""2015-02-09 20:41:26Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Moon.Precent"",
           ""Description"": """",
           ""Value"": ""71%"",
           ""UpdateTime"": ""2015-02-09 20:41:26Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Moon.Waxing"",
           ""Description"": """",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:41:26Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Astronomical.End"",
           ""Description"": """",
           ""Value"": ""06:58"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Astronomical.Start"",
           ""Description"": """",
           ""Value"": ""06:26"",
           ""UpdateTime"": ""2015-02-09 20:41:23Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Civil.End"",
           ""Description"": """",
           ""Value"": ""08:02"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Civil.Start"",
           ""Description"": """",
           ""Value"": ""07:33"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.GoldenHour.End"",
           ""Description"": """",
           ""Value"": ""08:44"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.GoldenHour.Start"",
           ""Description"": """",
           ""Value"": ""08:06"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Nautical.End"",
           ""Description"": """",
           ""Value"": ""07:32"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Nautical.Start"",
           ""Description"": """",
           ""Value"": ""06:59"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Night.End"",
           ""Description"": """",
           ""Value"": ""06:25"",
           ""UpdateTime"": ""2015-02-09 20:41:23Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Sunrise.End"",
           ""Description"": """",
           ""Value"": ""08:05"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Morning.Sunrise.Start"",
           ""Description"": """",
           ""Value"": ""08:03"",
           ""UpdateTime"": ""2015-02-09 20:41:24Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Night.Nadir"",
           ""Description"": """",
           ""Value"": ""01:10"",
           ""UpdateTime"": ""2015-02-09 20:41:23Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Night.Start"",
           ""Description"": """",
           ""Value"": ""19:53"",
           ""UpdateTime"": ""2015-02-09 20:41:23Z""
       },
       {
           ""Name"": ""jkUtils.SolarAltitude.Timeformat"",
           ""Description"": """",
           ""Value"": ""FALSE"",
           ""UpdateTime"": ""2015-02-09 20:41:22Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Day.Noon"",
           ""Description"": """",
           ""Value"": ""13:52"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Day.Start"",
           ""Description"": """",
           ""Value"": ""04:23"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Astronomical.End"",
           ""Description"": """",
           ""Value"": ""23:19"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Astronomical.Start"",
           ""Description"": """",
           ""Value"": ""22:31"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Civil.End"",
           ""Description"": """",
           ""Value"": ""21:48"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Civil.Start"",
           ""Description"": """",
           ""Value"": ""21:16"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.GoldenHour.Start"",
           ""Description"": """",
           ""Value"": ""20:34"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Nautical.End"",
           ""Description"": """",
           ""Value"": ""22:30"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Nautical.Start"",
           ""Description"": """",
           ""Value"": ""21:49"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Night.Start"",
           ""Description"": """",
           ""Value"": ""23:20"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Sunset.End"",
           ""Description"": """",
           ""Value"": ""21:15"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Evening.Sunset.Start"",
           ""Description"": """",
           ""Value"": ""21:13"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.LastUpdated"",
           ""Description"": """",
           ""Value"": ""07:22"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.LastUpdatedValue"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-04-11 18:49:40Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Moon.Angle"",
           ""Description"": """",
           ""Value"": ""1.39968139485275"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Moon.Fraction"",
           ""Description"": """",
           ""Value"": ""0.856646166983184"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Moon.Precent"",
           ""Description"": """",
           ""Value"": ""86%"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Moon.Waxing"",
           ""Description"": """",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Astronomical.End"",
           ""Description"": """",
           ""Value"": ""05:11"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Astronomical.Start"",
           ""Description"": """",
           ""Value"": ""04:23"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Civil.End"",
           ""Description"": """",
           ""Value"": ""06:27"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Civil.Start"",
           ""Description"": """",
           ""Value"": ""05:54"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.GoldenHour.End"",
           ""Description"": """",
           ""Value"": ""07:09"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Nautical.End"",
           ""Description"": """",
           ""Value"": ""05:53"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Nautical.Start"",
           ""Description"": """",
           ""Value"": ""05:12"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Night.End"",
           ""Description"": """",
           ""Value"": ""04:22"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Sunrise.End"",
           ""Description"": """",
           ""Value"": ""06:31"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Morning.Sunrise.Start"",
           ""Description"": """",
           ""Value"": ""06:28"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Night.Nadir"",
           ""Description"": """",
           ""Value"": ""01:52"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.SunCalc.Night.Start"",
           ""Description"": """",
           ""Value"": ""23:20"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""Program.Status"",
           ""Description"": """",
           ""Value"": ""Running"",
           ""UpdateTime"": ""2015-02-09 20:41:13Z""
       },
       {
           ""Name"": ""VirtualModule.ParentId"",
           ""Description"": """",
           ""Value"": ""501"",
           ""UpdateTime"": ""2015-02-09 21:31:50Z""
       },
       {
           ""Name"": ""Widget.DisplayModule"",
           ""Description"": """",
           ""Value"": ""jkUtils/SolarAltitude/SolarAltitude"",
           ""UpdateTime"": ""2014-05-18 05:29:02Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""jkUtils - OpenWeatherData"",
   ""Description"": """",
   ""DeviceType"": ""Program"",
   ""Domain"": ""HomeAutomation.HomeGenie.Automation"",
   ""Address"": ""503"",
   ""Properties"": [ 
       {
           ""Name"": ""ConfigureOptions.Custom Color"",
           ""Description"": ""HUE Color Value"",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.Custom Display Units"",
           ""Description"": ""Display System of Units (TRUE = use metric system, FALSE = use imperial system)"",
           ""Value"": ""TRUE"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.Custom Zoom"",
           ""Description"": ""Custom Zoom"",
           ""Value"": ""100%"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.Language"",
           ""Description"": ""Language. See http://OpenWeatherMap.org/API for available langugae codes."",
           ""Value"": ""fr"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.Location"",
           ""Description"": ""City name"",
           ""Value"": ""xxxxxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""ConfigureOptions.UpdateInterval"",
           ""Description"": ""Update interval in minutes. Default is 60 minutes."",
           ""Value"": ""60"",
           ""UpdateTime"": ""2015-02-09 20:40:53Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Clouds.All"",
           ""Description"": """",
           ""Value"": ""0"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Cod"",
           ""Description"": """",
           ""Value"": ""200"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Coord.Lat"",
           ""Description"": """",
           ""Value"": ""xxx.xxx"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Coord.Lon"",
           ""Description"": """",
           ""Value"": ""xxx.xxxx"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Dt"",
           ""Description"": """",
           ""Value"": ""1423517589"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Id"",
           ""Description"": """",
           ""Value"": ""2972315"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.LastUpdated"",
           ""Description"": """",
           ""Value"": ""1423518096"",
           ""UpdateTime"": ""2015-02-09 21:41:36Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.Humidity"",
           ""Description"": """",
           ""Value"": ""78"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.Pressure"",
           ""Description"": """",
           ""Value"": ""1022.59"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.Pressure.Previous"",
           ""Description"": """",
           ""Value"": ""1022.59"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.PressureGround"",
           ""Description"": """",
           ""Value"": ""1022.59"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.PressureSea"",
           ""Description"": """",
           ""Value"": ""1042.8"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.Temp"",
           ""Description"": """",
           ""Value"": ""-1.617"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.Temp.Previous"",
           ""Description"": """",
           ""Value"": ""-1.617"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.TempMax"",
           ""Description"": """",
           ""Value"": ""-1.617"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Main.TempMin"",
           ""Description"": """",
           ""Value"": ""-1.617"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Name"",
           ""Description"": """",
           ""Value"": ""Toulouse"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Rain.H1"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Rain.H24"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Rain.H3"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Rain.Today"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Snow.H1"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Snow.H24"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Snow.H3"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Snow.Today"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Sys.Country"",
           ""Description"": """",
           ""Value"": ""FR"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Sys.Message"",
           ""Description"": """",
           ""Value"": ""0.0915"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Sys.Sunrise"",
           ""Description"": """",
           ""Value"": ""1423465232"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Sys.Sunset"",
           ""Description"": """",
           ""Value"": ""1423502178"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Temp.Label"",
           ""Description"": """",
           ""Value"": ""°C"",
           ""UpdateTime"": ""2015-02-09 21:41:36Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Weather.Description"",
           ""Description"": """",
           ""Value"": ""ensoleillé"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Weather.Icon"",
           ""Description"": """",
           ""Value"": ""01n"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Weather.Id"",
           ""Description"": """",
           ""Value"": ""800"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Weather.Main"",
           ""Description"": """",
           ""Value"": ""Clear"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Wind.Deg"",
           ""Description"": """",
           ""Value"": ""243.002"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Wind.Gust"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Wind.Label"",
           ""Description"": """",
           ""Value"": ""m/s"",
           ""UpdateTime"": ""2015-02-09 21:41:36Z""
       },
       {
           ""Name"": ""jkUtils.OpenWeatherMap.Wind.Speed"",
           ""Description"": """",
           ""Value"": ""3.37"",
           ""UpdateTime"": ""2015-02-09 21:41:37Z""
       },
       {
           ""Name"": ""Program.Status"",
           ""Description"": """",
           ""Value"": ""Running"",
           ""UpdateTime"": ""2015-02-09 20:41:13Z""
       },
       {
           ""Name"": ""VirtualModule.ParentId"",
           ""Description"": """",
           ""Value"": ""503"",
           ""UpdateTime"": ""2015-02-09 21:31:50Z""
       },
       {
           ""Name"": ""Widget.DisplayModule"",
           ""Description"": """",
           ""Value"": ""jkUtils/OpenWeatherMap/OpenWeatherMap"",
           ""UpdateTime"": ""2014-05-18 05:40:16Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Shutter 7"",
   ""Description"": ""ZWave Node"",
   ""DeviceType"": ""Shutter"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.ScheduleControl"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-07-30 09:40:08Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOff"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-07-30 09:40:08Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOn"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-07-30 09:40:08Z""
       },
       {
           ""Name"": ""HomeGenie.ZWaveLevelPoll"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-07-30 09:40:08Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-07-30 09:40:08Z""
       },
       {
           ""Name"": ""Sensor.Generic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Status.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.1"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Count"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Max"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Generic.Sensor"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""xxxx:xxxx:xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-06-28 13:49:20Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-06-28 13:49:20Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.250"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpInterval"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Shutter 8"",
   ""Description"": """",
   ""DeviceType"": ""Shutter"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.ScheduleControl"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-12 20:48:27Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOff"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-12 20:48:27Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOn"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-12 20:48:27Z""
       },
       {
           ""Name"": ""HomeGenie.ZWaveLevelPoll"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-12 20:48:27Z""
       },
       {
           ""Name"": ""LastEvent.Enable"",
           ""Description"": """",
           ""Value"": ""On"",
           ""UpdateTime"": ""2015-02-09 20:40:55Z""
       },
       {
           ""Name"": ""Sensor.Generic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Status.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""Status.Level"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.1"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Count"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Associations.Max"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Battery"",
           ""Description"": """",
           ""Value"": ""xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.DeviceHandler"",
           ""Description"": """",
           ""Value"": ""ZWaveLib.Devices.ProductHandlers.Generic.Sensor"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.ManufacturerSpecific"",
           ""Description"": """",
           ""Value"": ""xxxx:xxxx:xxxx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-12 20:56:50Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2014-11-12 20:56:50Z""
       },
       {
           ""Name"": ""ZWaveNode.NodeInfo"",
           ""Description"": """",
           ""Value"": ""xx xx xx xx xx xx xx xx"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.Variables.250"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.WakeUpNotify"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       }   ],
   ""RoutingNode"": """"
},
{
   ""Name"": ""Shutter 9"",
   ""Description"": """",
   ""DeviceType"": ""Shutter"",
   ""Domain"": ""HomeAutomation.ZWave"",
   ""Address"": ""xx"",
   ""Properties"": [ 
       {
           ""Name"": ""HomeGenie.ScheduleControl"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOff"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""HomeGenie.ScheduleOn"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""HomeGenie.ZWaveLevelPoll"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""Sensor.Generic"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""TimeTable.Enable"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""TimeTable.Holiday"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""TimeTable.Special"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""TimeTable.Weekend"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""TimeTable.Workday"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 08:57:43Z""
       },
       {
           ""Name"": ""VirtualMeter.Watts"",
           ""Description"": """",
           ""Value"": ""1"",
           ""UpdateTime"": ""2015-02-09 20:40:56Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchBinary.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 20:41:10Z""
       },
       {
           ""Name"": ""ZWaveNode.MultiInstance.SwitchMultiLevel.Count"",
           ""Description"": """",
           ""Value"": """",
           ""UpdateTime"": ""2015-02-09 20:41:10Z""
       }   ],
   ""RoutingNode"": """"
}]";
    }
}
