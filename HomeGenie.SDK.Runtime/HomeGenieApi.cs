using System;
using System.Collections.Generic;
using System.Globalization;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;
using HomeGenie.SDK.Utility;
using Newtonsoft.Json;

namespace HomeGenie.SDK
{
    public class HomeGenieApi : IHomeGenieApi
    {
        private readonly HTTPRequestQueue _httpManager;

        public HomeGenieApi()
        {
            _httpManager = new HTTPRequestQueue();
        }

        public void UpdateGroups(Action<List<Group>> callback)
        {
            Calljsonapi("UpdateGroups", "/api/HomeAutomation.HomeGenie/Config/Groups.List", callback);
        }

        public void UpdateGroupModule(string groupname, Action<List<Module>> callback)
        {
            Calljsonapi("UpdateGroupModules[" + groupname + "]",
                "/api/HomeAutomation.HomeGenie/Config/Groups.ModulesList/" + groupname, callback);
        }

        public void SetModuleOn(Module module, Action<WebRequestCompletedArgs> callback)
        {
            string url = "/api/" + module.Domain + "/" + module.Address + "/Control.On//" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            Calljsonapi("Control.On", url, callback);
        }

        public void SetModuleOff(Module module, Action<WebRequestCompletedArgs> callback)
        {
            string url = "/api/" + module.Domain + "/" + module.Address + "/Control.Off//" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            Calljsonapi("Control.Off", url, callback);
        }

        public void SetLevel(Module module, double value, Action<WebRequestCompletedArgs> callback)
        {
            string url = "/api/" + module.Domain + "/" + module.Address + "/Control.Level/" + Math.Round(value * 100).ToString(CultureInfo.InvariantCulture) + "/" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            Calljsonapi("Control.Level", url, callback);
        }

        public void RunProgram(Module module, Group group, Action<WebRequestCompletedArgs> callback)
        {
            string url = "/api/HomeAutomation.HomeGenie/Automation/Programs.Run/" + module.Address + "/" + group.Name + "/" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            Calljsonapi("Programs.Run[" + module.Address + "]", url, callback);
        }

        public void SetLightColor(Module module, HSBColor color, Action<WebRequestCompletedArgs> callback)
        {
             string url = "/api/" + module.Domain + "/" + module.Address + "/Control.ColorHsb/" + 
                 (color.H / 360d).ToString(CultureInfo.InvariantCulture) + ',' + 
                 (color.S).ToString(CultureInfo.InvariantCulture) + ',' + 
                 (color.B).ToString(CultureInfo.InvariantCulture) + "/" + DateTime.Now.Ticks.ToString();
             Calljsonapi("Control.ColorHsb", url, callback);
        }

        private void Calljsonapi<T>(string reqid, string apiurl, Action<T> callback)
        {
            string url = apiurl + "/" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
            _httpManager.AddToQueue(reqid, url, args =>
            {
                if (args.RequestStatus == WebRequestStatus.Completed)
                {
                    callback(JsonConvert.DeserializeObject<T>(args.ResponseText));
                }
                else
                {
                    throw new LoadDataError();
                }
            });
        }
    }
}