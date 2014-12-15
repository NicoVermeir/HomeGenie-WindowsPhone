using System.Windows.Input;
using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using HGUniversal.Model;
using HomeGenie.SDK.Contracts;

namespace HGUniversal.ViewModel
{
    public class ConnectionViewModel : HomeGenieViewModelBase
    {
        private readonly ISettingsService _settingsService;
        private readonly INavigationService _navigationService;
        private Connection _connection;
        private ICommand _saveSettingsCommand;

        public ICommand SaveSettingsCommand
        {
            get { return _saveSettingsCommand ?? (_saveSettingsCommand = new RelayCommand(SaveSettings)); }
        }

        public Connection Connection
        {
            get { return _connection; }
            set { Set(() => Connection, ref _connection, value); }
        }

        public ConnectionViewModel(ISettingsService settingsService, INavigationService navigationService)
        {
            _settingsService = settingsService;
            _navigationService = navigationService;
            Connection = new Connection();
            LoadSettings();
        }

        private void LoadSettings()
        {
            Connection.ServerAddress = !_settingsService.DoesSettingExist(Constants.ServerAddressSetting) ?
                "127.0.0.1" : _settingsService.GetValue<string>(Constants.ServerAddressSetting);

            Connection.Username = !_settingsService.DoesSettingExist(Constants.UsernameSetting) ?
                "admin" : _settingsService.GetValue<string>(Constants.UsernameSetting);

            Connection.Password = !_settingsService.DoesSettingExist(Constants.PasswordSetting)?
                            "admin" : _settingsService.GetValue<string>(Constants.PasswordSetting);

            Connection.NotificationsEnabled = !_settingsService.DoesSettingExist(Constants.NotificationsEnabledSetting) || _settingsService.GetValue<bool>(Constants.NotificationsEnabledSetting);

            StateContainer.CurrentConnection = Connection;
        }

        private void SaveSettings()
        {
            _settingsService.SetValue(Constants.ServerAddressSetting, Connection.ServerAddress);
            _settingsService.SetValue(Constants.UsernameSetting, Connection.Username);
            _settingsService.SetValue(Constants.PasswordSetting, Connection.Password);
            _settingsService.SetValue(Constants.NotificationsEnabledSetting, Connection.NotificationsEnabled);

            _navigationService.GoBack();
        }
    }
}
