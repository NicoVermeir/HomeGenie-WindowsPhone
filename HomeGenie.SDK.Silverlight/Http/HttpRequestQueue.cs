using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Services;

namespace HomeGenie.SDK.Http
{
    public enum WebRequestStatus { Completed, WebException, BeginWebRequestGeneralError, FinishWebRequestGeneralError };

    public class HTTPRequestQueue
    {
        private readonly ISettingsService _settingsService;
        private readonly IStorageService _storageService;

        enum QueueStatus { Stopped, OnGoing }; // Queue can be in one of these states

        private QueueStatus _currentStatus;
        private QueueRequest _currentRequest;
        private HttpWebRequest _webRequest;
        private const String AppSettingsFileName = "httpreq_queue.xml";

        public List<QueueRequest> Requests = new List<QueueRequest>();

        public HTTPRequestQueue()
        {
            _storageService = new StorageService();
            _settingsService = new SettingsService();
            _currentStatus = QueueStatus.Stopped;
            _webRequest = null;
        }

        public void AddToQueue(string id, string url, Action<WebRequestCompletedArgs> callback)
        {
            QueueRequest qr  = Requests.FirstOrDefault(r => r.Id == id);
            if (qr == null) Requests.Add(new QueueRequest(id, url, callback));
            MakeNextRequest();
        }

        public void AddToQueue(string url, Action<WebRequestCompletedArgs> callback)
        {

            Requests.Add(new QueueRequest(url, callback));
            MakeNextRequest();
        }

        public void Start()
        {
            MakeNextRequest();
        }

        public void StopAndSaveQueue() //This will stop request queue and save pending requests to a file. 
        {
            if (_currentStatus == QueueStatus.OnGoing)
            {
                _currentStatus = QueueStatus.Stopped;
                if (_webRequest != null)
                    _webRequest.Abort();
                Requests.Insert(0, _currentRequest);

            }
            Save();
        }

        //Private functions 
        void MakeNextRequest()
        {

            if (_currentStatus == QueueStatus.OnGoing)
            {

                if (!Requests.Any())
                {
                    _currentStatus = QueueStatus.Stopped;
                }
                else if (Requests.Any() && _webRequest == null)
                {
                    MakeRequest();
                }

            }
            else if (_currentStatus == QueueStatus.Stopped)
            {
                if (Requests.Any() && _webRequest == null)
                {
                    _currentStatus = QueueStatus.OnGoing;
                    MakeRequest();
                }
            }
        }

        void MakeRequest()
        {
            if (_currentStatus == QueueStatus.Stopped)
                return;

            _currentRequest = Requests.First();

            try
            {
                _webRequest = (HttpWebRequest)WebRequest.Create(_currentRequest.Url);
                if (_settingsService.DoesSettingExist("RemoteServerUsername") &&
                    (string)_settingsService.GetValue("RemoteServerUsername") != "" &&
                    _settingsService.DoesSettingExist("RemoteServerPassword") &&
                    (string)_settingsService.GetValue("RemoteServerPassword") != "")
                {
                    _webRequest.Credentials = new NetworkCredential((string)_settingsService.GetValue("RemoteServerUsername"), (string)_settingsService.GetValue("RemoteServerPassword"));
                }
                _webRequest.BeginGetResponse(FinishWebRequest, this);
            }
            catch (WebException)
            {
                _webRequest = null;
                if (_currentRequest.Callback != null)
                {
                    _currentRequest.Callback(new WebRequestCompletedArgs(WebRequestStatus.WebException));
                }
            }
            catch
            {
                _webRequest = null;
                if (_currentRequest.Callback != null)
                {
                    _currentRequest.Callback(new WebRequestCompletedArgs(WebRequestStatus.BeginWebRequestGeneralError));
                }
            }
            //
            if (_webRequest != null)
            {
                Requests.RemoveAt(0);
            }
        }

        void RequestCompleted(QueueRequest request, string responseString)
        {
            if (request.Callback != null)
            {
                request.Callback(new WebRequestCompletedArgs(responseString));
            }
        }

        void FinishWebRequest(IAsyncResult result)
        {
            HTTPRequestQueue ptr = (HTTPRequestQueue)result.AsyncState;

            if (_currentStatus == QueueStatus.Stopped)
            {
                ptr._webRequest = null; //Queue is been stopped 
                return;
            }

            HttpWebRequest request = ptr._webRequest;
            HttpWebResponse response = null;
            Stream streamResponse = null;
            StreamReader streamRead = null;
            WebRequestStatus status = WebRequestStatus.Completed;

            bool requestSuccess = true;

            try
            {
                // End the operation
                response = (HttpWebResponse)request.EndGetResponse(result);
                streamResponse = response.GetResponseStream();
                streamRead = new StreamReader(streamResponse);
                string responseString = streamRead.ReadToEnd();
                RequestCompleted(_currentRequest, responseString); //Request completed succesfully

            }
            catch (WebException)
            {
                requestSuccess = false;
                status = WebRequestStatus.WebException;
            }
            catch (Exception)
            {
                requestSuccess = false;
                status = WebRequestStatus.FinishWebRequestGeneralError;
            }
            finally
            {
                // Close stream objects
                if (streamResponse != null)
                    streamResponse.Dispose();
                if (streamRead != null)
                    streamRead.Dispose();
                if (response != null)
                    response.Dispose();

                ptr._webRequest = null;

                if (requestSuccess)
                    MakeNextRequest();
                else
                {
                    if (_currentRequest.Callback != null)
                    {
                        _currentRequest.Callback(new WebRequestCompletedArgs(status));
                    }
                }
            }
        }

        void Save()
        {
            _storageService.SaveAsXML(AppSettingsFileName, this);
        }

        public static HTTPRequestQueue Load()
        {
            IStorageService storageService = new StorageService();
            HTTPRequestQueue tmpQueue = storageService.FileExists(AppSettingsFileName) ?
                storageService.LoadFromXML<HTTPRequestQueue>(AppSettingsFileName) :
                new HTTPRequestQueue();

            return tmpQueue;
        }
    }
}
