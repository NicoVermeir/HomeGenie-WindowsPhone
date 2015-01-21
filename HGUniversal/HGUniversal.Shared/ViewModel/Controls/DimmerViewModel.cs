using System;
using System.Linq;
using System.Windows.Input;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using HGUniversal.Common;
using HGUniversal.View;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;
using HomeGenie.SDK.Utility;
using RelayCommand = GalaSoft.MvvmLight.Command.RelayCommand;

namespace HGUniversal.ViewModel.Controls
{
    public class DimmerViewModel : ControlViewModelBase, IDimmerVM
    {
        private bool _isReady;

        private readonly IHomeGenieApi _api;
        private readonly INavigationService _navigationService;

        private double _sliderValue;
        private bool _isSwitchedOn;

        private SolidColorBrush _lightColor;

        private ICommand _selectColorCommand;
        private ICommand _colorSelectedCommand;
        private Color _color;

        public DimmerViewModel()
        {
            _api = SimpleIoc.Default.GetInstance<IHomeGenieApi>();
            _navigationService = SimpleIoc.Default.GetInstance<INavigationService>();
        }

        public ICommand ColorSelectedCommand
        {
            get
            {
                return _colorSelectedCommand ?? (_colorSelectedCommand = new Common.RelayCommand(() => _navigationService.GoBack()));
            }
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
                if (Set(() => IsSwitchedOn, ref _isSwitchedOn, value) && _isReady)
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
            set
            {
                if (Set(() => LightColor, ref _lightColor, value))
                {
                    _color = LightColor.Color;
                }
            }
        }

        public Color Color
        {
            get { return _color; }
            set
            {
                if (Set(() => Color, ref _color, value))
                {
                    LightColor = new SolidColorBrush(Color);
                }
            }
        }

        private void ToggleLight()
        {
            if (IsSwitchedOn)
            {
                _api.SetModuleOn(Module);
                SetSlider(true);
                RaisePropertyChanged(() => SliderValue);
            }
            else
            {
                _api.SetModuleOff(Module);
                _sliderValue = 0.0;
                RaisePropertyChanged(() => SliderValue);
            }
            RaisePropertyChanged(() => Module);
        }

        private void UpdateLevel()
        {
            if (_isReady)
                _api.SetLevel(Module, SliderValue / 100);
        }

        internal override void SetValues()
        {
            //Slider
            SetSlider();

            //color
            if (
                Module.Properties.Any(
                    prop => prop.Name == "Widget.DisplayModule" &&
                        prop.Value == "homegenie/generic/colorlight"))
            {
                ModuleParameter colorProperty = Module.Properties.FirstOrDefault(prop => prop.Name == "Status.ColorHsb");
                if (colorProperty == null) return;
                HSBColor hsbColor = HSBColor.FromString(colorProperty.Value);
                LightColor = new SolidColorBrush(hsbColor.ToColor());
            }

            _isReady = true;
        }

        private void SetSlider(bool setToMemoryValue = false)
        {
            ModuleParameter levelProperty;

            if (setToMemoryValue)
            {
                levelProperty = Module.Properties.FirstOrDefault(prop =>
                prop.Name == "Status.MemoryLevel");

                //occurs when the module is not a dimmermodule
                if (levelProperty == null)
                    return;

                var a = Module.Properties.FirstOrDefault(prop =>
                prop.Name == "Status.Level");
                SetProperty(a, levelProperty.Value, DateTime.Now);
            }
            else
            {
                levelProperty = Module.Properties.FirstOrDefault(prop => 
                prop.Name == "Status.Level");
            }
            
            if (levelProperty == null) return;

            double value;

            if (double.TryParse(levelProperty.Value, out value))
            {
                if(value > 0)
                    _sliderValue = value * 100;
                RaisePropertyChanged(() => SliderValue);
            }

            //toggleswitch
            IsSwitchedOn = value > 0;
        }

        private void SelectColor()
        {
            Messenger.Default.Register<ColorChangedMessage>(this, msg =>
            {
                Color = msg.SelectedColor;
                Messenger.Default.Unregister<ColorChangedMessage>(this);

                _api.SetLightColor(Module, HSBColor.FromColor(Color));
            });
            _navigationService.Navigate<ColorPickerPage>();
        }
    }
}