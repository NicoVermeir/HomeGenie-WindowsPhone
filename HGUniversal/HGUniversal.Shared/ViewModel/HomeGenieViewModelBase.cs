using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using GalaSoft.MvvmLight;
using HGUniversal.BackgroundTasks;

namespace HGUniversal.ViewModel
{
    public class HomeGenieViewModelBase : ViewModelBase
    {
        private bool _isDataLoading;

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
    }
}
