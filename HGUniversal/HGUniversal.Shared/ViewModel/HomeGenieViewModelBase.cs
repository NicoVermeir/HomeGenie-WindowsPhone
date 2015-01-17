using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight;
using HGUniversal.BackgroundTasks;

namespace HGUniversal.ViewModel
{
    public class HomeGenieViewModelBase : ViewModelBase
    {
        private bool _isDataLoading;
        private string _pinUnpinText;
        private SymbolIcon _pinUnpinIcon;

        public bool IsDataLoading
        {
            get { return _isDataLoading; }
            set
            {
                if (_isDataLoading == value) return;
                _isDataLoading = value;
                RaisePropertyChanged();
            }
        }

        public string PinUnpinText
        {
            get { return _pinUnpinText; }
            set { Set(() => PinUnpinText, ref _pinUnpinText, value); }
        }

        public SymbolIcon PinUnpinIcon
        {
            get { return _pinUnpinIcon; }
            set { Set(() => PinUnpinIcon, ref _pinUnpinIcon, value); }
        }

        protected void ToggleAppBarButton(bool showPinButton)
        {
            if (showPinButton)
            {
                PinUnpinText = "pin";
                PinUnpinIcon = new SymbolIcon(Symbol.Pin);
            }
            else
            {
                PinUnpinText = "unpin";
                PinUnpinIcon = new SymbolIcon(Symbol.UnPin);
            }
        }

        protected async Task RegisterTask()
        {
            const string name = "TileUpdateTask";

            //check if the task already exists
            if (BackgroundTaskRegistration.AllTasks.Any(cur => cur.Value.Name == name))
            {
                return;
            }

            await BackgroundExecutionManager.RequestAccessAsync();
            var taskBuilder = new BackgroundTaskBuilder { Name = name };
            var trigger = new TimeTrigger(15, false);
            var condition = new SystemCondition(SystemConditionType.InternetAvailable);

            taskBuilder.SetTrigger(trigger);
            taskBuilder.AddCondition(condition);

            taskBuilder.TaskEntryPoint = typeof(TileUpdateTask).FullName;
            taskBuilder.Register();
        }

        protected void PopToast(string message)
        {
            const ToastTemplateType toastTemplate = ToastTemplateType.ToastText01;
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastTemplate);
            XmlNodeList toastTextElements = toastXml.GetElementsByTagName("text");
            toastTextElements[0].AppendChild(toastXml.CreateTextNode(message));
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}
