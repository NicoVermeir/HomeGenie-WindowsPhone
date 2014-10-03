using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Net;
using System.Windows.Controls;

namespace HomeGenie.ViewModel.Converters
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
                string baseurl = "http://" + (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerAddress"];
                HttpWebRequest wreq = (HttpWebRequest)WebRequest.Create(baseurl + url);
                if (IsolatedStorageSettings.ApplicationSettings.Contains("RemoteServerUsername") &&
                    (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerUsername"] != "" &&
                    IsolatedStorageSettings.ApplicationSettings.Contains("RemoteServerPassword") &&
                    (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerPassword"] != "")
                {
                    wreq.Credentials = new NetworkCredential((string)IsolatedStorageSettings.ApplicationSettings["RemoteServerUsername"], (string)IsolatedStorageSettings.ApplicationSettings["RemoteServerPassword"]);
                }
                //wreq.AllowWriteStreamBuffering = true;

                wreq.BeginGetResponse((IAsyncResult result) => {
                    Image img = (Image)result.AsyncState;
                    try
                    {
                        HttpWebResponse res = (HttpWebResponse)wreq.EndGetResponse(result);
                        img.Dispatcher.BeginInvoke(() =>
                        {
                            BitmapImage bi = new BitmapImage();
                            bi.SetSource(res.GetResponseStream());
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
