﻿namespace HomeGenie.SDK.Contracts
{
    public interface ISettingsService
    {
        bool DoesSettingExist(string settingName);
        object GetValue(string settingName);
        T GetValue<T>(string settingName);
        void SetValue(string settingName, object value);
    }
}