using System;
using System.IO;
using System.Xml.Serialization;
using Windows.Storage;
using HomeGenie.SDK.Contracts;

namespace HomeGenie.SDK.Services
{
    public class StorageService : IStorageService
    {
        public async void SaveAsXML(string fileName, object item)
        {
            var file = await ApplicationData.Current.RoamingFolder.CreateFileAsync(fileName);

            Stream stream = await file.OpenStreamForWriteAsync();
            try
            {
                var xml = new XmlSerializer(item.GetType());
                xml.Serialize(stream, item);
            }
            // ReSharper disable once EmptyGeneralCatchClause
            catch
            { }
            finally
            {
                stream.Flush();
                stream.Dispose();
            }
        }

        public bool FileExists(string fileName)
        {
            var task = ApplicationData.Current.RoamingFolder.GetFileAsync(fileName).AsTask();
            task.Wait();

            return task.Result != null;
        }

        public T LoadFromXML<T>(string fileName)
        {
            var task = ApplicationData.Current.RoamingFolder.GetFileAsync(fileName).AsTask();
            task.Wait();

            var streamTask = task.Result.OpenReadAsync().AsTask();
            streamTask.Wait();

            Stream stream = streamTask.Result.AsStream();
            try
            {
                var xml = new XmlSerializer(typeof(T));
                return (T)xml.Deserialize(stream);
            }
            catch (Exception)
            {
                return default(T);
            }
            finally
            {
                stream.Flush();
                stream.Dispose();
            }
        }
    }
}