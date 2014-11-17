using HomeGenie.SDK.Contracts;

namespace HGUniversal.DesignTimeData
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

        public T GetValue<T>(string settingName)
        {
            return default(T);
        }

        public void SetValue(string settingName, object value)
        {
            
        }
    }
}