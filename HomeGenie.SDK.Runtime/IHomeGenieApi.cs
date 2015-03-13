using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using HomeGenie.SDK.Objects;
using HomeGenie.SDK.Utility;

namespace HomeGenie.SDK
{
    public interface IHomeGenieApi
    {
        Task<List<Group>> LoadGroups();
        Task<List<Module>> LoadGroupModules(string groupname);
        Task<IRandomAccessStream> GetImageStream(string url);
        Task SetModuleOn(Module module);
        Task SetModuleOff(Module module);
        Task SetLevel(Module module, double value);
        Task SetLightColor(Module module, HSBColor color);
        Task RunProgram(Module module, Group group);
    }
}