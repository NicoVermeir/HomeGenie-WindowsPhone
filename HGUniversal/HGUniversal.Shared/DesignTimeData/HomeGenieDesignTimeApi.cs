using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HomeGenie.SDK;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;
using HomeGenie.SDK.Utility;

namespace HGUniversal.DesignTimeData
{
    public class HomeGenieDesignTimeApi : IHomeGenieApi
    {
        public void UpdateGroups(Action<List<Group>> callback)
        {
            var designData = new List<Group>();

            for (int i = 0; i < 10; i++)
            {
                var group = new Group();
                group.Name = "design module " + i;
                group.Modules = CreateModules();
                designData.Add(group);
            }
            callback(designData);
        }

        private ObservableCollection<Module> CreateModules()
        {
            var modules = new ObservableCollection<Module>();
            for (int i = 0; i < 5; i++)
            {
                var module = new Module
                {
                    Address = "",
                    Description = "",
                    DeviceType = Module.DeviceTypes.Dimmer,
                    Name = "module " + i
                };

                var param = new ModuleParameter {Name = "Widget.DisplayModule", Value = "homegenie/generic/colorlight"};
                module.Properties.Add(param);
                modules.Add(module);
            }
            return modules;
        }

        private List<Module> CreateModulesForGroup()
        {
            var modules = new List<Module>();
            for (int i = 0; i < 5; i++)
            {
                var module = new Module
                {
                    Address = "",
                    Description = "",
                    DeviceType = (Module.DeviceTypes)i,
                    Name = "module " + i
                };
                modules.Add(module);
            }
            return modules;
        }

        public void UpdateGroupModule(string groupname, Action<List<Module>> callback)
        {
            var modules = CreateModulesForGroup();
            callback(modules);
        }

        public void SetModuleOn(Module module, Action<WebRequestCompletedArgs> callback)
        {
            
        }

        public void SetModuleOff(Module module, Action<WebRequestCompletedArgs> callback)
        {
            
        }

        public void SetLevel(Module module, double value, Action<WebRequestCompletedArgs> callback)
        {
            
        }

        public void SetLightColor(Module module, HSBColor color, Action<WebRequestCompletedArgs> callback)
        {
            
        }

        public void RunProgram(Module module, Group @group, Action<WebRequestCompletedArgs> callback)
        {
            
        }
    }
}