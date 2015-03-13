using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HomeGenie.SDK.Annotations;

namespace HomeGenie.SDK.Objects
{
    public class Group:INotifyPropertyChanged
{
        private double? _groupTemperature;
        private double? _groupLuminance;
        private int _numberOfSwitches;
        private double? _groupHumidity;
        public string Name { get; set; }

        public double? GroupTemperature
        {
            get { return _groupTemperature; }
            set
            {
                if (value.Equals(_groupTemperature)) return;
                _groupTemperature = value;
                OnPropertyChanged();
            }
        }

        public double? GroupHumidity
        {
            get { return _groupHumidity; }
            set
            {
                if (value.Equals(_groupHumidity)) return;
                _groupHumidity = value;
                OnPropertyChanged();
            }
        }

        public double? GroupLuminance
        {
            get { return _groupLuminance; }
            set
            {
                if (value.Equals(_groupLuminance)) return;
                _groupLuminance = value;
                OnPropertyChanged();
            }
        }

        public int NumberOfLights { get; set; }

        public int NumberOfSwitches
        {
            get { return _numberOfSwitches; }
            set
            {
                if (value == _numberOfSwitches) return;
                _numberOfSwitches = value;
                OnPropertyChanged();
            }
        }

        public IList<Module> Modules { get; set; }

    public Group()
    {
        Modules = new List<Module>();
    }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
}
}
