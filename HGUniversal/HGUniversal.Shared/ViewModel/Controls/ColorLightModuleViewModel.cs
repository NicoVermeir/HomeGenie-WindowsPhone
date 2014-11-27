using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using HGUniversal.View;

namespace HGUniversal.ViewModel.Controls
{
    public class ColorLightModuleViewModel : DimmerViewModel, IDimmerVM
    {
        private RelayCommand _selectColorCommand;
        private readonly INavigationService _navigationService;

        public RelayCommand SelectColorCommand
        {
            get { return _selectColorCommand ?? (_selectColorCommand = new RelayCommand(() => _navigationService.Navigate<ColorPickerPage>())); }
        }

        public ColorLightModuleViewModel()
        {
            _navigationService = SimpleIoc.Default.GetInstance<INavigationService>();
        }
    }
}
