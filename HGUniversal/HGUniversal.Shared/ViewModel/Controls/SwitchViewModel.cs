using System.Linq;
using System.Windows.Input;
using Windows.UI.Xaml.Media;
using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using HGUniversal.View;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;
using HomeGenie.SDK.Utility;

namespace HGUniversal.ViewModel.Controls
{
    public class SwitchViewModel : ControlViewModelBase, ISwitchVM
    {
        private readonly IHomeGenieApi _api;
        private readonly INavigationService _navigationService;
         
        private bool _isSwitchedOn;

        public SwitchViewModel()
        {
            Module = new Module
            {
                Address = "",
                Description = "",
                DeviceType = Module.DeviceTypes.Switch,
                Name = "design time switch"
            };

            _api = SimpleIoc.Default.GetInstance<IHomeGenieApi>();
            _navigationService = SimpleIoc.Default.GetInstance<INavigationService>();
        }

        public bool IsSwitchedOn
        {
            get { return _isSwitchedOn; }
            set
            {
                if (Set(() => IsSwitchedOn, ref _isSwitchedOn, value))
                {
                    ToggleLight();
                }
            }
        }
        private void ToggleLight()
        {
            if (IsSwitchedOn)
            {
                _api.SetModuleOn(Module, Callback);
            }
            else
            {
                _api.SetModuleOff(Module, Callback);
            }
        }

        internal override void SetValues()
        {
            
        }
    }
}