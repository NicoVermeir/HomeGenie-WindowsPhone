using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Data;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using GalaSoft.MvvmLight.Ioc;
using HomeGenie.SDK.Contracts;

namespace HGUniversal.ViewModel.Converters
{
    public class ModuleIconUrlConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string url = (string)values[1];
            if (url.StartsWith("http://") || url.StartsWith("https://"))
            {

                return new BitmapImage(new Uri(url));
            }
            else if (url.StartsWith("/Assets/"))
            {
                return new BitmapImage(new Uri(url, UriKind.Relative));
            }
            else
            {
                var settingsService = SimpleIoc.Default.GetInstance<ISettingsService>();

                string baseurl = "http://" + (string)settingsService.GetValue("RemoteServerAddress");
                var wreq = (HttpWebRequest)WebRequest.Create(baseurl + url);
                if (settingsService.DoesSettingExist("RemoteServerUsername") &&
                    (string)settingsService.GetValue("RemoteServerUsername") != "" &&
                    settingsService.DoesSettingExist("RemoteServerPassword") &&
                    (string)settingsService.GetValue("RemoteServerPassword") != "")
                {
                    wreq.Credentials = new NetworkCredential((string)settingsService.GetValue("RemoteServerUsername"), (string)settingsService.GetValue("RemoteServerPassword"));
                }
                //wreq.AllowWriteStreamBuffering = true;

                wreq.BeginGetResponse(result =>
                {
                    var img = (Image)result.AsyncState;
                    try
                    {
                        var res = (HttpWebResponse)wreq.EndGetResponse(result);
                        img.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            var bi = new BitmapImage();
                            var s = new InMemoryRandomAccessStream();
                            bi.SetSource(res.GetResponseStream().AsRandomAccessStream());
                            img.Source = bi;
                        });
                    }
                    catch { }
                }, (Image)values[0]);

                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
