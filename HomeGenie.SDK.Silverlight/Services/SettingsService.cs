using System.IO.IsolatedStorage;
using HomeGenie.SDK.Contracts;

namespace HomeGenie.SDK.Services
{
    public class SettingsService : ISettingsService
    {
        public bool DoesSettingExist(string settingName)
        {
            return IsolatedStorageSettings.ApplicationSettings.Contains(settingName);
        }

        public object GetValue(string settingName)
        {
            return IsolatedStorageSettings.ApplicationSettings[settingName];
        }

        public void SetValue(string settingName, object value)
        {
            if (DoesSettingExist(settingName))
            {
                IsolatedStorageSettings.ApplicationSettings[settingName] = value;
            }
            else
            {
                IsolatedStorageSettings.ApplicationSettings.Add(settingName, value);
            }
        }
    }
}