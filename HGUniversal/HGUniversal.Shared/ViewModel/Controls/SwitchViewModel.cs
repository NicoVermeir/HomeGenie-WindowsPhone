using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Ioc;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;

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
                if (Set(ref _isSwitchedOn, value))
                {
                    ToggleLight();
                }
            }
        }
        private void ToggleLight()
        {
            if (IsSwitchedOn)
            {
                _api.SetModuleOn(Module);
            }
            else
            {
                _api.SetModuleOff(Module);
            }

            RaisePropertyChanged("Module.IconUrl");
        }

        internal override void SetValues()
        {
            
        }
    }
}