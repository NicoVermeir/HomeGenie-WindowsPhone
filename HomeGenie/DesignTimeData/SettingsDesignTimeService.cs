using HomeGenie.SDK.Contracts;

namespace HomeGenie.DesignTimeData
{
    public class SettingsDesignTimeService : ISettingsService
    {
        public bool DoesSettingExist(string settingName)
        {
            return true;
        }

        public object GetValue(string settingName)
        {
            return new object();
        }

        public void SetValue(string settingName, object value)
        {
            
        }
    }
}