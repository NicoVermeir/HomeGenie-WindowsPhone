using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel.Controls
{
    public class ProgramViewModel : ControlViewModelBase, IProgramVM
    {
        private ICommand _runProgramCommand;
        private IHomeGenieApi _api;

        public ICommand RunProgramCommand
        {
            get { return _runProgramCommand ?? (_runProgramCommand = new RelayCommand(RunProgram)); }
        }

        public ProgramViewModel()
        {
            Module = new Module
            {
                Address = "",
                Description = "",
                DeviceType = Module.DeviceTypes.Dimmer,
                Name = "design time module"
            };

            _api = SimpleIoc.Default.GetInstance<IHomeGenieApi>();
        }

        private void RunProgram()
        {
            _api.RunProgram(Module, Group, Callback);
        }
    }
}