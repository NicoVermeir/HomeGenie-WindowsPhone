using System;
using System.Collections.Generic;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;

namespace HomeGenie.SDK
{
    public interface IHomeGenieApi
    {
        void UpdateGroups(Action<List<Group>> callback);
        void UpdateGroupModule(string groupname, Action<List<Module>> callback);
        void SetModuleOn(Module module, Action<WebRequestCompletedArgs> callback);
        void SetModuleOff(Module module, Action<WebRequestCompletedArgs> callback);
        void SetLevel(Module module, double value, Action<WebRequestCompletedArgs> callback);
    }
}