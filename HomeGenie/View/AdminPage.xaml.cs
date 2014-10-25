using System;
using System.IO.IsolatedStorage;
using System.Windows;
using Microsoft.Phone.Controls;

namespace HomeGenie.View
{
    public partial class AdminPage : PhoneApplicationPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           Uri adminuri = new Uri(("http://" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerAddress"]));
           if (IsolatedStorageSettings.ApplicationSettings.Contains("RemoteServerUsername") &&
               (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerUsername"] != "" &&
               IsolatedStorageSettings.ApplicationSettings.Contains("RemoteServerPassword") &&
               (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerPassword"] != "")
           {
               adminuri = new Uri(("http://" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerUsername"] + ":" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerPassword"] + "@" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerAddress"]));
           }

           Browser.Navigate(adminuri);
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}