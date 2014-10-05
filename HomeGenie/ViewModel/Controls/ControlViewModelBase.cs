using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using HomeGenie.Common;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel.Controls
{
    public abstract class ControlViewModelBase : ObservableObject
    {
        private Module _module;
        internal Action<WebRequestCompletedArgs> Callback;

        protected ControlViewModelBase()
        {
            Callback = args=> Messenger.Default.Send(new RefreshGroupsMessage());
        }

        public Module Module
        {
            get { return _module; }
            set
            {
                if (_module == value) return;
                _module = value;
                RaisePropertyChanged();
            }
        }
    }
}