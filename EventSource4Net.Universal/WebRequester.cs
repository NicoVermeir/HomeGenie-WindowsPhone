using System;
using System.Net;
using System.Threading.Tasks;
using HomeGenie.SDK;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Services;

namespace EventSource4Net
{
    class WebRequester : IWebRequester
    {
        private readonly ISettingsService _settingsService;

        public WebRequester()
        {
            _settingsService = new SettingsService();                        
        }

        public Task<IServerResponse> Get(Uri url)
        {
            var wreq = (HttpWebRequest)WebRequest.Create(url);
            wreq.Method = "GET";
            wreq.Proxy = null;
            wreq.Credentials = GetCredentials();

            var taskResp = Task.Factory.FromAsync<WebResponse>(wreq.BeginGetResponse,
                                                            wreq.EndGetResponse,
                                                            null).ContinueWith<IServerResponse>(t => new ServerResponse(t.Result));
            return taskResp;
        }

        public NetworkCredential GetCredentials()
        {
            string username = _settingsService.GetValue<string>(Constants.UsernameSetting);
            string password = _settingsService.GetValue<string>(Constants.PasswordSetting);

            return new NetworkCredential(username, password);
        }
    }
}
