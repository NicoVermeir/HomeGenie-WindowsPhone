﻿using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace HomeGenie.View
{
    public partial class SetupPage : PhoneApplicationPage
    {
        private bool _justopened = true;

        public SetupPage()
        {
            InitializeComponent();          
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (_justopened)
            {
                _justopened = false;
                //
                // TODO: settings check here...
                //
                //Thread t = new Thread(() =>
                //{
                //    Thread.Sleep(500);
                //    this.Dispatcher.BeginInvoke(() => {
                //        this.NavigationService.Navigate(new Uri("/GroupsPage.xaml", UriKind.Relative));
                //    });
                //});
                //t.Start();
            }
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack(); // .Navigate(new Uri("/GroupsPage.xaml", UriKind.Relative));
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (((CheckBox)sender).IsChecked == true)
            {
                App.SetupPushChannel();
                App.SubscribePushNotifications();
            }
            else
            {
                App.RemovePushChannel();
                App.UnsubscribePushNotifications();
            }
        }
    }
}