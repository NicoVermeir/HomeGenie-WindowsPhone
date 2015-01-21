using HomeGenie.SDK.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeGenie.SDK.DummyObjects;
using HomeGenie.SDK.Utility;
using Newtonsoft.Json;

namespace HomeGenie.SDK
{
    public class DummyApi : IHomeGenieApi
    {
        public async Task<List<Group>> LoadGroups()
        {
            var groups = new List<Group>();

            for (int i = 0; i < 5; i++)
            {
                var group = new Group();
                group.Name = string.Format("Dummy group {0}", i);

                groups.Add(group);
            }

            return groups;
        }

        public async Task<List<Module>> LoadGroupModules(string groupname)
        {
            Module mod = JsonConvert.DeserializeObject<Module>(Modules.ModuleJson);

            return new List<Module> { mod };
        }

        public async Task SetModuleOn(Module module)
        {
        }

        public async Task SetModuleOff(Module module)
        {
        }

        public async Task SetLevel(Module module, double value)
        {
        }

        public async Task SetLightColor(Module module, HSBColor color)
        {
        }

        public async Task RunProgram(Module module, Group group)
        {
        }
    }
}
