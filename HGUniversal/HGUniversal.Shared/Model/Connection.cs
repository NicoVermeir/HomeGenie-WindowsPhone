using GalaSoft.MvvmLight;

namespace HGUniversal.Model
{
    public class Connection : ObservableObject
    {
        private string _username;
        private string _password;
        private string _serverAddress;
        private bool _notificationsEnabled;

        public string Username
        {
            get { return _username; }
            set { Set(() => Username, ref _username, value); }
        }

        public string Password
        {
            get { return _password; }
            set { Set(() => Password, ref _password, value); }
        }

        public string ServerAddress
        {
            get { return _serverAddress; }
            set { Set(() => ServerAddress, ref _serverAddress, value); }
        }

        public bool NotificationsEnabled
        {
            get { return _notificationsEnabled; }
            set { Set(() => NotificationsEnabled, ref _notificationsEnabled, value); }
        }
    }
}
