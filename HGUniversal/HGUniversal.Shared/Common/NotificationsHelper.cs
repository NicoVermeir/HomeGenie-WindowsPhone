// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.PushNotifications;
using Windows.Storage;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Services;

namespace HGUniversal.Common
{
    public sealed class ChannelAndWebResponse
    {
        public PushNotificationChannel Channel { get; set; }
        public String WebResponse { get; set; }
    }

    [DataContract]
    internal class UrlData
    {
        [DataMember]
        public String Url;
        [DataMember]
        public String ChannelUri;
        [DataMember]
        public bool IsAppId;
        [DataMember]
        public DateTime Renewed;
    }

    public sealed class Notifier
    {
        private const String AppTileIdKey = "HGPushChannel";
        private const String MainAppTileKey = "HomeGenie";
        private const int DaysToRenew = 15; // Renew if older than 15 days
        private readonly Dictionary<String, UrlData> _urls;
        private ISettingsService _settingsService;

        public Notifier()
        {
            _settingsService = new SettingsService();
            _urls = new Dictionary<String, UrlData>();
            List<String> storedUrls = null;
            IPropertySet currentData = ApplicationData.Current.LocalSettings.Values;

            try
            {
                String urlString = (String)currentData[AppTileIdKey];

                if (string.IsNullOrWhiteSpace(urlString))
                {
                    return;
                }

                using (MemoryStream stream = new MemoryStream(Encoding.Unicode.GetBytes(urlString)))
                {
                    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<String>));
                    storedUrls = (List<String>)deserializer.ReadObject(stream);
                }
            }
            catch (Exception) { }

            if (storedUrls != null)
            {
                for (int i = 0; i < storedUrls.Count; i++)
                {
                    String key = storedUrls[i];
                    try
                    {
                        String dataString = (String)currentData[key];
                        using (MemoryStream stream = new MemoryStream(Encoding.Unicode.GetBytes(dataString)))
                        {
                            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(UrlData));
                            this._urls[key] = (UrlData)deserializer.ReadObject(stream);
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

        private UrlData TryGetUrlData(String key)
        {
            UrlData returnedData = null;
            lock (this._urls)
            {
                if (this._urls.ContainsKey(key))
                {
                    returnedData = this._urls[key];
                }
            }

            return returnedData;
        }

        private void SetUrlData(String key, UrlData dataToSet)
        {
            lock (this._urls)
            {
                this._urls[key] = dataToSet;
            }
        }

        // Update the stored target URL
        private void UpdateUrl(String url, String channelUri, String inputItemId, bool isPrimaryTile)
        {
            String itemId = isPrimaryTile && inputItemId == null ? MainAppTileKey : inputItemId;

            bool shouldSerializeTileIds = TryGetUrlData(itemId) == null;
            UrlData storedData = new UrlData() { Url = url, ChannelUri = channelUri, IsAppId = isPrimaryTile, Renewed = DateTime.Now };
            SetUrlData(itemId, storedData);

            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(UrlData));
                serializer.WriteObject(stream, storedData);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    ApplicationData.Current.LocalSettings.Values[itemId] = reader.ReadToEnd();
                }
            }

            if (shouldSerializeTileIds)
            {
                SaveAppTileIds();
            }
        }

        private void SaveAppTileIds()
        {
            List<String> dataToStore;

            lock (this._urls)
            {
                dataToStore = new List<String>(this._urls.Count);
                foreach (String key in this._urls.Keys)
                {
                    dataToStore.Add(key);
                }
            }

            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<String>));
                serializer.WriteObject(stream, dataToStore);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    ApplicationData.Current.LocalSettings.Values[AppTileIdKey] = reader.ReadToEnd();
                }
            }
        }

        // This method checks the freshness of each channel, and returns as necessary
        public IAsyncAction RenewAllAsync(bool force)
        {
            DateTime now = DateTime.Now;
            TimeSpan daysToRenew = new TimeSpan(DaysToRenew, 0, 0, 0);
            List<Task<ChannelAndWebResponse>> renewalTasks;
            lock (this._urls)
            {
                renewalTasks = new List<Task<ChannelAndWebResponse>>(this._urls.Count);
                foreach (var keyValue in this._urls)
                {
                    UrlData dataForUpload = keyValue.Value;
                    if (force || ((now - dataForUpload.Renewed) > daysToRenew))
                    {
                        if (keyValue.Key == MainAppTileKey)
                        {
                            renewalTasks.Add(OpenChannelAndUploadAsync(dataForUpload.Url).AsTask());
                        }
                        else
                        {
                            renewalTasks.Add(OpenChannelAndUploadAsync(dataForUpload.Url, keyValue.Key, dataForUpload.IsAppId).AsTask());
                        }

                    }
                }
            }
            return Task.WhenAll(renewalTasks).AsAsyncAction();
        }

        // Instead of using the async and await keywords, actual Tasks will be returned.
        // That way, components consuming these APIs can await the returned tasks
        public IAsyncOperation<ChannelAndWebResponse> OpenChannelAndUploadAsync(String url)
        {
            IAsyncOperation<PushNotificationChannel> channelOperation = PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();
            return ExecuteChannelOperation(channelOperation, url, MainAppTileKey, true);
        }

        public IAsyncOperation<ChannelAndWebResponse> OpenChannelAndUploadAsync(String url, String inputItemId, bool isPrimaryTile)
        {
            IAsyncOperation<PushNotificationChannel> channelOperation;
            if (isPrimaryTile)
            {
                channelOperation = PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync(inputItemId);
            }
            else
            {
                channelOperation = PushNotificationChannelManager.CreatePushNotificationChannelForSecondaryTileAsync(inputItemId);
            }

            return ExecuteChannelOperation(channelOperation, url, inputItemId, isPrimaryTile);
        }

        private IAsyncOperation<ChannelAndWebResponse> ExecuteChannelOperation(IAsyncOperation<PushNotificationChannel> channelOperation, String url, String itemId, bool isPrimaryTile)
        {
            return channelOperation.AsTask().ContinueWith<ChannelAndWebResponse>((Task<PushNotificationChannel> channelTask) =>
            {
                PushNotificationChannel newChannel = channelTask.Result;
                String webResponse = "URI already uploaded";

                // Upload the channel URI if the client hasn't recorded sending the same uri to the server
                UrlData dataForItem = TryGetUrlData(itemId);

                if (dataForItem == null || newChannel.Uri != dataForItem.ChannelUri)
                {
                    HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                    webRequest.Method = "POST";
                    webRequest.ContentType = "application/x-www-form-urlencoded";
                    webRequest.Credentials = GetCredentials();

                    byte[] channelUriInBytes = Encoding.UTF8.GetBytes("ChannelUri=" + WebUtility.UrlEncode(newChannel.Uri) + "&ItemId=" + WebUtility.UrlEncode(itemId));

                    Task<Stream> requestTask = webRequest.GetRequestStreamAsync();
                    using (Stream requestStream = requestTask.Result)
                    {
                        requestStream.Write(channelUriInBytes, 0, channelUriInBytes.Length);
                    }

                    Task<WebResponse> responseTask = webRequest.GetResponseAsync();
                    using (StreamReader requestReader = new StreamReader(responseTask.Result.GetResponseStream()))
                    {
                        webResponse = requestReader.ReadToEnd();
                    }
                }

                // Only update the data on the client if uploading the channel URI succeeds.
                // If it fails, you may considered setting another AC task, trying again, etc.
                // OpenChannelAndUploadAsync will throw an exception if upload fails
                UpdateUrl(url, newChannel.Uri, itemId, isPrimaryTile);
                return new ChannelAndWebResponse { Channel = newChannel, WebResponse = webResponse };
            }).AsAsyncOperation();
        }

        public NetworkCredential GetCredentials()
        {
            string username = _settingsService.GetValue<string>(Constants.UsernameSetting);
            string password = _settingsService.GetValue<string>(Constants.PasswordSetting);

            return new NetworkCredential(username, password);
        }
    }
}
