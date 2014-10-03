using System;
using System.Collections.Generic;
using System.Globalization;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;
using Newtonsoft.Json;

namespace HomeGenie.SDK
{
    public class ServerMethods
    {
        private readonly HTTPRequestQueue _httpManager;

        public ServerMethods()
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