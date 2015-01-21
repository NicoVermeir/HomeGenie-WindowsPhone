using GalaSoft.MvvmLight;

namespace HGUniversal.Model
{
    public class Connection : ObservableObject
    {
        private string _username;
        private string _password;
        private string _serverAddress;
        private bool _notificationsEnabled;
        private string _port;

        public string Username
        {
            get { return _username; }
            set { Set(ref _username, value); }
        }

        public string Password
        {
            get { return _password; }
            set { Set(ref _password, value); }
        }

        public string ServerAddress
        {
            get { return _serverAddress; }
            set { Set(ref _serverAddress, value); }
        }

        public string Port
        {
            get { return _port; }
            set { Set(ref _port, value); }
        }

        public bool NotificationsEnabled
        {
            get { return _notificationsEnabled; }
            set { Set(ref _notificationsEnabled, value); }
        }
    }
}
