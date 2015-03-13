using System;
using System.Globalization;
using System.IO;
using System.Net;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Cimbalino.Toolkit.Converters;
using GalaSoft.MvvmLight.Ioc;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Objects.Error;

namespace HGUniversal.Converters
{
    public class ModuleIconUrlConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var settingsService = SimpleIoc.Default.GetInstance<ISettingsService>();
            string url = (string)values[1];

            if (url == null)
                return null;

            if (url.StartsWith("http://") || url.StartsWith("https://"))
            {
                return new BitmapImage(new Uri(url));
            }

            if (url.StartsWith("/Assets/"))
            {
                return new BitmapImage(new Uri(url, UriKind.Relative));
            }
            var baseurl = settingsService.GetValue<string>(Constants.ServerAddressSetting);
            var username = settingsService.GetValue<string>(Constants.UsernameSetting);
            var password = settingsService.GetValue<string>(Constants.PasswordSetting);
            var port = settingsService.GetValue<string>(Constants.PortSetting);

            HttpWebRequest wreq = WebRequest.Create("http://" + baseurl + ":" + port + url) as HttpWebRequest;
            if (wreq != null)
            {
                wreq.Credentials = new NetworkCredential(username, password);

                wreq.BeginGetResponse(result =>
                {
                    var img = (Image)result.AsyncState;
                    try
                    {
                        HttpWebResponse res = (HttpWebResponse)wreq.EndGetResponse(result);

                        if (img == null)
                            return;

                        img.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
                        {
                            BitmapImage bi = new BitmapImage();
                            Stream stream = res.GetResponseStream();
                            var memStream = new MemoryStream();
                            await stream.CopyToAsync(memStream);
                            memStream.Position = 0;

                            bi.SetSource(memStream.AsRandomAccessStream());
                            img.Source = bi;
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new HomeGenieException(ex.Message, "ImageLoader");
                    }
                }, (Image)values[0]);
            }

            return null;
        }

        public override object[] ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
