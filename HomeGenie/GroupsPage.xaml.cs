#define DEBUG_AGENT

using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Threading;
using Microsoft.Phone.Tasks;

namespace HomeGenie
{
    public partial class GroupsPage : PhoneApplicationPage
    {
        private readonly Timer _statupdate;
        private const int Updateinterval = 5000;

        public GroupsPage()
        {
            InitializeComponent();

            Loaded += GroupsPage_Loaded;

            _statupdate = new Timer(_systemStatusPoll);
        }


        private void GroupsPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("EnableNotifications") && (bool)IsolatedStorageSettings.ApplicationSettings["EnableNotifications"])
            {
                App.SetupPushChannel();
            } 
        }

        private void _systemStatusPoll(object target)
        {
            //App.ViewModel.UpdateCurrentGroup();
            _statupdate.Change(Updateinterval, Timeout.Infinite);
        }
        #region Application Bar events handling

        private void OpenHelp_Click(object sender, EventArgs e)
        {
            _openHelpPage();
        }

        private void OpenInfo_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void OpenSettings_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SetupPage.xaml", UriKind.Relative));
        }

        private void OpenAdmin_Click(object sender, EventArgs e)
        {
            Uri adminuri = new Uri(("http://" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerAddress"]));
            if (IsolatedStorageSettings.ApplicationSettings.Contains("RemoteServerUsername") &&
                (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerUsername"] != "" &&
                IsolatedStorageSettings.ApplicationSettings.Contains("RemoteServerPassword") &&
                (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerPassword"] != "")
            {
                adminuri = new Uri(("http://" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerUsername"] + ":" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerPassword"] + "@" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerAddress"]));
            }
            PhoneApplicationService.Current.State["WebBrowserPageUrl"] = adminuri;
            NavigationService.Navigate(new Uri("/WebBrowserPage.xaml", UriKind.Relative));
        }

        #endregion


        private void _openHelpPage()
        {
            Uri helpuri = new Uri("http://generoso.info/homegenie/learn.html");
            //PhoneApplicationService.Current.State["WebBrowserPageUrl"] = helpuri;
            //this.NavigationService.Navigate(new Uri("/WebBrowserPage.xaml", UriKind.Relative));
            WebBrowserTask task = new WebBrowserTask();
            task.Uri = helpuri;
            task.Show();
        }
    }
}