using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using Cimbalino.Toolkit.Extensions;
using EventSource4Net;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using HGUniversal.Model;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Objects;
using Newtonsoft.Json;

namespace HGUniversal
{
    public static class StateContainer
    {
        private static CancellationTokenSource _cancellationToken;
        private static EventSource _eventClient;
        private static ISettingsService _settingsService;
        private static EventSourceState _eventClientState;
        public static event EventHandler ConnectionUpdated;

        public static Connection CurrentConnection { get; set; }

        public static void AnnounceConnectionUpdated()
        {
            if (ConnectionUpdated != null) ConnectionUpdated(null, EventArgs.Empty);
        }

        //eventserver
        public static void Connect()
        {
            Disconnect();

            if (_settingsService == null)
                _settingsService = SimpleIoc.Default.GetInstance<ISettingsService>();

            //var serverCredential = new NetworkCredential(user, pass);
            _cancellationToken = new CancellationTokenSource();
            _eventClient = new EventSource(new Uri("http://" + _settingsService.GetValue<string>(Constants.ServerAddressSetting) + "/api/HomeAutomation.HomeGenie/Logging/RealTime.EventStream/"), 10000);
            _eventClient.StateChanged += eventClient_StateChanged;
            _eventClient.EventReceived += eventClient_EventReceived;

            _eventClient.Start(_cancellationToken.Token);
        }

        public static void Disconnect()
        {
            if (_cancellationToken != null)
                _cancellationToken.Cancel();
        }

        private static void eventClient_EventReceived(object sender, ServerSentEventReceivedEventArgs e)
        {
            Event eventObject = JsonConvert.DeserializeObject<Event>(e.Message.Data);
            Messenger.Default.Send(eventObject);
        }

        private static void eventClient_StateChanged(object sender, StateChangedEventArgs e)
        {
            _eventClientState = e.State;
        }
    }
}
