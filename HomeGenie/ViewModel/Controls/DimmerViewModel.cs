using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel.Controls
{
    public class DimmerViewModel : ControlViewModelBase
    {
        private double _sliderValue;
        private readonly ServerMethods _api;

        private ICommand _sliderLevelChangedCommand;
        private bool _isSwitchedOn;

        public ICommand SliderLevelChangedCommand
        {
            get { return _sliderLevelChangedCommand ?? (_sliderLevelChangedCommand = new RelayCommand(UpdateLevel)); }
        }

        public DimmerViewModel(Module module)
        {
            Module = module;
            _api = SimpleIoc.Default.GetInstance<ServerMethods>();
            SetValues();
        }

        public bool IsSwitchedOn
        {
            get { return _isSwitchedOn; }
            set
            {
                if (_isSwitchedOn == value) return;
                _isSwitchedOn = value;
                RaisePropertyChanged();
                ToggleLight();
            }
        }

        public double SliderValue
        {
            get { return _sliderValue; }
            set
            {
                if (_sliderValue == value) return;
                _sliderValue = value;
                RaisePropertyChanged();
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

        private void UpdateLevel()
        {
            _api.SetLevel(Module, SliderValue / 100, Callback);
        }

        private void SetValues()
        {
            //Slider
            ModuleParameter levelProperty = Module.Properties.FirstOrDefault(prop => prop.Name == "Status.Level");
            if (levelProperty == null) return;

            double value;

            if (double.TryParse(levelProperty.Value, out value))
                SliderValue = value * 100;

            //toggleswitch
            IsSwitchedOn = value > 0;
        }
    }
}