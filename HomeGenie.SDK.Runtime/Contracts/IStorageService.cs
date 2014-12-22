using System;
using HomeGenie.SDK.Http;

namespace HomeGenie.SDK.Contracts
{
    public interface IStorageService
    {
        void SaveAsXML(string fileName, object item);
        bool FileExists(string fileName);
        T LoadFromXML<T>(string fileName);
    }
}