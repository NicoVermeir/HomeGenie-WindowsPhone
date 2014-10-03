using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;
using HomeGenie.SDK.Contracts;

namespace HomeGenie.SDK.Services
{
    public class StorageService : IStorageService
    {
        readonly IsolatedStorageFile _storage;

        public StorageService()
        {
            _storage = IsolatedStorageFile.GetUserStoreForApplication();
        }

        public void SaveAsXML(string fileName, object item)
        {
            IsolatedStorageFileStream stream = _storage.CreateFile(fileName);

            try
            {
                XmlSerializer xml = new XmlSerializer(item.GetType());
                xml.Serialize(stream, item);
            }
            // ReSharper disable once EmptyGeneralCatchClause
            catch
            { }
            finally
            {
                stream.Close();
                stream.Dispose();
            }
        }

        public bool FileExists(string fileName)
        {
            return _storage.FileExists(fileName);
        }

        public T LoadFromXML<T>(string fileName)
        {
            var stream = _storage.OpenFile(fileName, FileMode.Open);

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                return (T)xml.Deserialize(stream);
            }
            catch (Exception)
            {
                return default(T);
            }
            finally
            {
                stream.Close();
                stream.Dispose();
            }
        }
    }
}