using System;
using System.Windows.Input;
using Windows.Networking.PushNotifications;
using Cimbalino.Toolkit.Services;
using HGUniversal.Common;
using HGUniversal.Model;
using HomeGenie.SDK.Contracts;
using RelayCommand = GalaSoft.MvvmLight.Command.RelayCommand;

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
            set { Set(ref _connection, value); }
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

            Connection.Port = !_settingsService.DoesSettingExist(Constants.PortSetting) ?
                "80" : _settingsService.GetValue<string>(Constants.PortSetting);

            Connection.Username = !_settingsService.DoesSettingExist(Constants.UsernameSetting) ?
                "admin" : _settingsService.GetValue<string>(Constants.UsernameSetting);

            Connection.Password = !_settingsService.DoesSettingExist(Constants.PasswordSetting) ?
                            "admin" : _settingsService.GetValue<string>(Constants.PasswordSetting);

            Connection.NotificationsEnabled = !_settingsService.DoesSettingExist(Constants.NotificationsEnabledSetting) || _settingsService.GetValue<bool>(Constants.NotificationsEnabledSetting);

            StateContainer.CurrentConnection = Connection;
        }

        private async void SaveSettings()
        {
            IsDataLoading = true;
            _settingsService.SetValue(Constants.ServerAddressSetting, Connection.ServerAddress);
            _settingsService.SetValue(Constants.PortSetting, Connection.Port);
            _settingsService.SetValue(Constants.UsernameSetting, Connection.Username);
            _settingsService.SetValue(Constants.PasswordSetting, Connection.Password);
            _settingsService.SetValue(Constants.NotificationsEnabledSetting, Connection.NotificationsEnabled);

            StateContainer.AnnounceConnectionUpdated();

            if (Connection.NotificationsEnabled)
            {
                Notifier notifier = new Notifier();
                ChannelAndWebResponse response = await notifier.OpenChannelAndUploadAsync("http://" + Connection.ServerAddress);

                response.Channel.PushNotificationReceived += ChannelOnPushNotificationReceived;
            }
            else
            {
                Notifier notifier = new Notifier();
               
            }
            IsDataLoading = false;
            _navigationService.GoBack();
        }

        private void ChannelOnPushNotificationReceived(PushNotificationChannel sender, PushNotificationReceivedEventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
