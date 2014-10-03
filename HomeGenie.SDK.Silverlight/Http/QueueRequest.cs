using System;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Services;

namespace HomeGenie.SDK.Http
{
    public class QueueRequest
    {
        public string Url;
        public Action<WebRequestCompletedArgs> Callback;
        public string Id;

        public QueueRequest(string url, Action<WebRequestCompletedArgs> callback)
        {
            ISettingsService settingsService = new SettingsService();
            Url = "http://" + (string)settingsService.GetValue("RemoteServerAddress") + url;
            Callback = callback;
        }
        public QueueRequest(string id, string url, Action<WebRequestCompletedArgs> callback)
        {
            ISettingsService settingsService = new SettingsService();
            Id = id;
            Url = "http://" + (string)settingsService.GetValue("RemoteServerAddress") + url;
            Callback = callback;
        }
    }
}