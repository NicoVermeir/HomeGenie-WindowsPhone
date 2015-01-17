using System;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using HGUniversal.Model;
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
            Callback = args => Messenger.Default.Send(new RefreshGroupsMessage());
            Messenger.Default.Register<Event>(this, OnEventReceived);
        }

        private void OnEventReceived(Event eventObject)
        {
            if (eventObject.Domain != Module.Domain || eventObject.Source != Module.Address)
                return;

            var moduleProp = Module.Properties.FirstOrDefault(props => props.Name == eventObject.Property);
            if (moduleProp != null)
            {
                SetProperty(moduleProp, eventObject.Value, eventObject.Timestamp);
            }
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

        internal void SetProperty(ModuleParameter property, string value, DateTime timestamp)
        {
            var prop = Module.Properties.FirstOrDefault(p => p.Name == property.Name);

            if (prop == null) return;

            if (prop.UpdateTime.AddSeconds(10) >= timestamp || prop.Value == value) return;

            prop.LastValue = prop.Value;
            prop.LastUpdateTime = prop.UpdateTime;
            prop.Value = value;
            prop.UpdateTime = timestamp;

            DispatcherHelper.CheckBeginInvokeOnUI(SetValues);
        }
    }
}