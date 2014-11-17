using Windows.Storage;
using HomeGenie.SDK.Contracts;
using Newtonsoft.Json;

namespace HomeGenie.SDK.Services
{
    public class SettingsService : ISettingsService
    {
        public bool DoesSettingExist(string settingName)
        {
            var value = ApplicationData.Current.RoamingSettings.Values[settingName];
            return value != null;
        }

        public object GetValue(string settingName)
        {
            return ApplicationData.Current.RoamingSettings.Values[settingName];
        }

        public T GetValue<T>(string settingName)
        {
            return JsonConvert.DeserializeObject<T>(ApplicationData.Current.RoamingSettings.Values[settingName].ToString());
        }

        public void SetValue(string settingName, object value)
        {
            ApplicationData.Current.RoamingSettings.Values[settingName] = JsonConvert.SerializeObject(value);
        }
    }
}