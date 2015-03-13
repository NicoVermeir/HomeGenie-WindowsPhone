using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;
using HomeGenie.SDK.Utility;

namespace HGUniversal.DesignTimeData
{
    public class HomeGenieDesignTimeApi : IHomeGenieApi
    {
        public Task<List<Group>> LoadGroups()
        {
            throw new NotImplementedException();
        }

        public Task<List<Module>> LoadGroupModules(string groupname)
        {
            throw new NotImplementedException();
        }

        public async Task<IRandomAccessStream> GetImageStream(string url)
        {
            throw new NotImplementedException();
        }

        public Task SetModuleOn(Module module)
        {
            throw new NotImplementedException();
        }

        public Task SetModuleOff(Module module)
        {
            throw new NotImplementedException();
        }

        public Task SetLevel(Module module, double value)
        {
            throw new NotImplementedException();
        }

        public Task SetLightColor(Module module, HSBColor color)
        {
            throw new NotImplementedException();
        }

        public Task RunProgram(Module module, Group @group)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetImage(string url)
        {
            throw new NotImplementedException();
        }
    }
}