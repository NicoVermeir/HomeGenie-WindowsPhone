using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace HomeGenie.View
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
        }

        private void ReviewButton_Click(object sender, RoutedEventArgs e)
        {
            new MarketplaceReviewTask().Show();
        }

        private void SupportButton_Click(object sender, RoutedEventArgs e)
        {
            var emailComposeTask = new EmailComposeTask
            {
                To = "info@generoso.info",
                Subject = "[HomeGenie] feedback and support"
            };
            emailComposeTask.Show();
        }

        private void TextBlockAbout_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
            wbt.Uri = new Uri("http://generoso.info/homegenie");
            wbt.Show();
        }
    }
}