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
    public class DimmerViewModel : ControlViewModelBase, IDimmerVM
    {
        private readonly IHomeGenieApi _api;
        private readonly INavigationService _navigationService;

        private double _sliderValue;
        private bool _isSwitchedOn;

        private SolidColorBrush _lightColor;

        private ICommand _sliderLevelChangedCommand;
        private ICommand _selectColorCommand;

        public ICommand SliderLevelChangedCommand
        {
            get { return _sliderLevelChangedCommand ?? (_sliderLevelChangedCommand = new RelayCommand(UpdateLevel)); }
        }

        public DimmerViewModel()
        {
            Module = new Module
            {
                Address = "",
                Description = "",
                DeviceType = Module.DeviceTypes.Dimmer,
                Name = "design time module"
            };

            _api = SimpleIoc.Default.GetInstance<IHomeGenieApi>();
            _navigationService = SimpleIoc.Default.GetInstance<INavigationService>();
        }

        public ICommand SelectColorCommand
        {
            get { return _selectColorCommand ?? (_selectColorCommand = new RelayCommand(SelectColor)); }
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

        public double SliderValue
        {
            get { return _sliderValue; }
            set
            {
                if (Set(() => SliderValue, ref _sliderValue, value))
                {
                    UpdateLevel();
                }
            }
        }

        public SolidColorBrush LightColor
        {
            get { return _lightColor; }
            set { Set(() => LightColor, ref _lightColor, value); }
        }

        private void ToggleLight()
        {
            if (IsSwitchedOn)
            {
                _api.SetModuleOn(Module, Callback);
                SetSlider();
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

        internal override void SetValues()
        {
            //Slider
            SetSlider();

            //color
            if (
                Module.Properties.Any(
                    prop => prop.Name == "Widget.DisplayModule" && prop.Value == "homegenie/generic/colorlight"))
            {
                ModuleParameter colorProperty = Module.Properties.FirstOrDefault(prop => prop.Name == "Status.ColorHsb");
                if (colorProperty == null) return;
                HSBColor hsbColor = HSBColor.FromString(colorProperty.Value);
                LightColor = new SolidColorBrush(hsbColor.ToColor());
            }
        }

        private void SetSlider()
        {
            ModuleParameter levelProperty = Module.Properties.FirstOrDefault(prop => prop.Name == "Status.Level");
            if (levelProperty == null) return;

            double value;

            if (double.TryParse(levelProperty.Value, out value))
                SliderValue = value * 100;

            //toggleswitch
            IsSwitchedOn = value > 0;
        }

        private void SelectColor()
        {
            _navigationService.Navigate<ColorPickerPage>();
        }
    }
}