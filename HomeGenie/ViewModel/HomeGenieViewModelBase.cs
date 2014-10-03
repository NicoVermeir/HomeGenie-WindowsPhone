using System.Windows;
using GalaSoft.MvvmLight;

namespace HomeGenie.ViewModel
{
    public class HomeGenieViewModelBase : ViewModelBase
    {
        private bool _isDataLoading;

        public bool IsDataLoading
        {
            get { return _isDataLoading; }
            set
            {
                if (_isDataLoading == value) return;
                _isDataLoading = value;
                RaisePropertyChanged();
            }
        }
    }
}
