using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight.Threading;
using HomeGenie.SDK;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel
{
    public class MainViewModel : HomeGenieViewModelBase
    {
        private readonly ISettingsService _settingsService;
        private readonly ServerMethods _api;

        public ObservableCollection<Group> Items { get; private set; }
        private Group _currentgroup;

        public Group CurrentGroup
        {
            get
            {
                return _currentgroup;
            }
            set
            {
                if (_currentgroup == value) return;
                _settingsService.SetValue("CurrentGroup", value);
                _currentgroup = value;
                UpdateGroupModules();
                RaisePropertyChanged();
            }
        }

        public MainViewModel(ISettingsService settingsService, ServerMethods api)
        {
            _settingsService = settingsService;
            _api = api;
            Items = new ObservableCollection<Group>();
            if (_settingsService.DoesSettingExist("CurrentGroup"))
            {
                _currentgroup = (Group)_settingsService.GetValue("CurrentGroup");
            }

            LoadData();
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects in the collection of items.
        /// </summary>
        public void LoadData()
        {

            if (!_settingsService.DoesSettingExist("RemoteServerAddress"))
            {
                _settingsService.SetValue("RemoteServerAddress", "127.0.0.1");
            }
            if (!_settingsService.DoesSettingExist("RemoteServerUsername"))
            {
                _settingsService.SetValue("RemoteServerUsername", "admin");
            }
            if (!_settingsService.DoesSettingExist("RemoteServerPassword"))
            {
                _settingsService.SetValue("RemoteServerPassword", "");
            }
            if (!_settingsService.DoesSettingExist("RemoteServerUpdateInterval"))
            {
                _settingsService.SetValue("RemoteServerUpdateInterval", "20");
            }
            if (!_settingsService.DoesSettingExist("EnableNotifications"))
            {
                _settingsService.SetValue("EnableNotifications", true);
            }

            IsDataLoading = true;
            UpdateGroups();
        }

        private void UpdateGroups()
        {
            try
            {
                _api.UpdateGroups(result =>
                {
                    List<Group> groups = result;

                    if (groups != null)
                    {
                        List<Group> newgroups = new List<Group>();
                        foreach (Group g in groups)
                        {
                            Group existinggroup = Items.FirstOrDefault(eg => eg.Name == g.Name);

                            if (existinggroup != null)
                            {
                                existinggroup.Name = g.Name;
                            }
                            else
                            {
                                Group newgroup = g;
                                newgroup.Modules.Clear();
                                newgroups.Add(newgroup);
                            }
                        }

                        DispatcherHelper.CheckBeginInvokeOnUI(() =>
                        {
                            foreach (Group g in newgroups)
                            {
                                Items.Add(g);
                            }
                            IsDataLoading = false;
                        });
                    }
                });
            }
            catch (LoadDataError)
            {
                //TODO: show error
                MessageBox.Show("error");
            }

        }

        internal void UpdateGroupModules()
        {
            _api.UpdateGroupModule(CurrentGroup.Name, modules =>
            {
                Group g = Items.First(hz => hz.Name == CurrentGroup.Name);
                if (modules != null)
                    DispatcherHelper.CheckBeginInvokeOnUI(() =>
                    {
                        foreach (Module m in modules)
                        {
                            Module existinmodule = g.Modules.FirstOrDefault(gm => gm.Domain == m.Domain && gm.Address == m.Address);

                            if (existinmodule != null)
                            {
                                existinmodule.Name = m.Name;
                                existinmodule.Properties = m.Properties;
                            }
                            else
                            {
                                g.Modules.Add(m);
                            }
                        }
                    });
            });
        }
    }
}