using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Objects;
using HomeGenie.SDK.Services;
using HomeGenie.SDK.Utility;

namespace HomeGenie.SDK
{
    public class HomeGenieApi : IHomeGenieApi
    {
        private readonly IHttpService _httpService;

        public HomeGenieApi()
        {
            _httpService = new HttpService();
        }

        public async Task<List<Group>> LoadGroups()
        {
            string url = "/api/HomeAutomation.HomeGenie/Config/Groups.List";
            return await _httpService.Get<List<Group>>(BuildUrl(url));
        }

        public async Task<List<Module>> LoadGroupModules(string groupname)
        {
            string url = "/api/HomeAutomation.HomeGenie/Config/Groups.ModulesList/" + groupname;
            return await _httpService.Get<List<Module>>(BuildUrl(url));
        }

        public async Task SetModuleOn(Module module)
        {
            string url = "/api/" + module.Domain + "/" + module.Address + "/Control.On//" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            await _httpService.Get<bool?>(BuildUrl(url));
        }

        public async Task SetModuleOff(Module module)
        {
            string url = "/api/" + module.Domain + "/" + module.Address + "/Control.Off//" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            await _httpService.Get<bool?>(BuildUrl(url));
        }

        public async Task SetLevel(Module module, double value)
        {
            string url = "/api/" + module.Domain + "/" + module.Address + "/Control.Level/" + Math.Round(value * 100).ToString(CultureInfo.InvariantCulture) + "/" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            await _httpService.Get<bool?>(BuildUrl(url));
        }

        public async Task RunProgram(Module module, Group group)
        {
            string url = "/api/HomeAutomation.HomeGenie/Automation/Programs.Run/" + module.Address + "/" + group.Name + "/" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            await _httpService.Get<bool?>(BuildUrl(url));
        }

        public async Task SetLightColor(Module module, HSBColor color)
        {
            string url = "/api/" + module.Domain + "/" + module.Address + "/Control.ColorHsb/" +
                (color.H / 360d).ToString(CultureInfo.InvariantCulture) + ',' +
                (color.S).ToString(CultureInfo.InvariantCulture) + ',' +
                (color.B).ToString(CultureInfo.InvariantCulture) + "/" + DateTime.Now.Ticks.ToString();
            await _httpService.Get<bool>(BuildUrl(url));
        }

        private string BuildUrl(string apiurl)
        {
            return apiurl + "/" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
        }
    }
}