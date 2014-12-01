using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using HomeGenie.Common;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;

namespace HGUniversal.ViewModel.Controls
{
    public abstract class ControlViewModelBase : ObservableObject, IModuleVM
    {
        private Module _module;
        internal Action<WebRequestCompletedArgs> Callback;
        public Group Group { get; set; }

        protected ControlViewModelBase()
        {
            Callback = args=> Messenger.Default.Send(new RefreshGroupsMessage());
        }

        public Module Module
        {
            get { return _module; }
            set
            {
                if (Set(() => Module, ref _module, value))
                {
                    SetValues();
                }
            }
        }

        internal abstract void SetValues();
    }
}