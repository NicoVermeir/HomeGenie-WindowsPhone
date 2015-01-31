using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Objects.Error;
using Newtonsoft.Json;

namespace HomeGenie.SDK.Services
{
    public class HttpService : IHttpService
    {
        private HttpClient _client;
        private readonly ISettingsService _settingsService;

        public HttpService()
        {
            _settingsService = new SettingsService();            
        }

        public async Task<T> Get<T>(string url)
        {
            string json = await CallClient(url);
            T results;

            try
            {
                results = JsonConvert.DeserializeObject<T>(json);
            }
            catch (JsonException ex)
            {
                throw new HomeGenieException(ex.Message, "Json Deserialisation");
            }

            if (results == null)
                return default(T);

            return results;
        }

        private async Task<string> CallClient(string url)
        {
            string fullUrl = string.Format("http://{0}:{1}{2}",
                _settingsService.GetValue<string>(Constants.ServerAddressSetting),
                _settingsService.GetValue<string>(Constants.PortSetting), url);

            var credentials = GetCredentials();
            var handler = new HttpClientHandler { Credentials = credentials };
            using (_client = new HttpClient(handler))
            {
                try
                {
                    return await _client.GetStringAsync(new Uri(fullUrl));
                }
                catch (Exception ex)
                {
                    throw new HomeGenieException(ex.Message, "HTTP Call");
                }
            }
        }

        public NetworkCredential GetCredentials()
        {
            string username = _settingsService.GetValue<string>(Constants.UsernameSetting);
            string password = _settingsService.GetValue<string>(Constants.PasswordSetting);

            return new NetworkCredential(username, password);
        }
    }
}