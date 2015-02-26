using System;
using System.Linq;
using GalaSoft.MvvmLight.Ioc;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;

namespace HGUniversal.ViewModel.Controls
{
    public class ShutterViewModel : ControlViewModelBase, IShutterVM
    {
        private readonly IHomeGenieApi _api;

        private double _sliderValue;

        public ShutterViewModel()
        {
            _api = SimpleIoc.Default.GetInstance<IHomeGenieApi>();
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

        private void UpdateLevel()
        {
            _api.SetLevel(Module, SliderValue / 100);
        }

        internal override void SetValues()
        {
            //Slider
            SetSlider();
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
                if (value > 0)
                    _sliderValue = value * 100;
                RaisePropertyChanged(() => SliderValue);
            }
        }
    }
}