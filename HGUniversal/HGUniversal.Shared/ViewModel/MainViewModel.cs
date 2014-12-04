using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Popups;
using Cimbalino.Toolkit.Helpers;
using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Threading;
using HGUniversal.View;
using HGUniversal.ViewModel.Controls;
using HomeGenie.SDK;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;

namespace HGUniversal.ViewModel
{
    public class MainViewModel : HomeGenieViewModelBase
    {
        private readonly ISettingsService _settingsService;
        private readonly IHomeGenieApi _api;
        private readonly INavigationService _navigationService;

        private Group _currentgroup;

        public ObservableCollection<Group> Items { get; private set; }
        public ObservableCollection<IModuleVM> ModulesForCurrentGroup { get; set; }

        public Group CurrentGroup
        {
            get
            {
                return _currentgroup;
            }
            set
            {
                if (Set(() => CurrentGroup, ref _currentgroup, value))
                    UpdateGroupModules();
            }
        }

        public MainViewModel(ISettingsService settingsService, IHomeGenieApi api, INavigationService navigationService)
        {
            _settingsService = settingsService;
            _api = api;
            _navigationService = navigationService;
            Items = new ObservableCollection<Group>();

            ModulesForCurrentGroup = new ObservableCollection<IModuleVM>();
            LoadData();
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects in the collection of items.
        /// </summary>
        public void LoadData()
        {
            if (!IsInDesignMode)
            {
                if (!_settingsService.DoesSettingExist("RemoteServerAddress"))
                {
#if DEBUG
                    _settingsService.SetValue("RemoteServerAddress", "192.168.1.144");
                    //_settingsService.SetValue("RemoteServerAddress", "127.0.0.1");
#else
                    _navigationService.Navigate<ConnectionPage>();
#endif
                }
                else
                {
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
                        _settingsService.SetValue("RsemoteServerUpdateInterval", "20");
                    }
                    if (!_settingsService.DoesSettingExist("EnableNotifications"))
                    {
                        _settingsService.SetValue("EnableNotifications", true);
                    }

                    IsDataLoading = true;
                    UpdateGroups();
                }
            }
            if (IsInDesignMode)
            {
                IsDataLoading = true;
                UpdateGroups();
            }
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
                        var newgroups = new List<Group>();
                        foreach (Group g in groups)
                        {
                            Group g1 = g;
                            Group existinggroup = Items.FirstOrDefault(eg => eg.Name == g1.Name);

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

                        if (!IsInDesignMode)
                        {
                            DispatcherHelper.CheckBeginInvokeOnUI(() =>
                            {
                                foreach (Group g in newgroups)
                                {
                                    Items.Add(g);
                                }
                                IsDataLoading = false;
                            });
                        }
                        else
                        {
                            foreach (Group g in newgroups)
                            {
                                Items.Add(g);
                            }
                            CurrentGroup = Items.First();
                            UpdateGroupModules();
                        }
                    }
                });
            }
            catch (LoadDataError)
            {
                //TODO: show error
                var d = new MessageDialog("error");
                d.ShowAsync();
            }

        }

        internal void UpdateGroupModules()
        {
            ModulesForCurrentGroup.Clear();

            _api.UpdateGroupModule(CurrentGroup.Name, modules =>
            {
                Group g = Items.First(hz => hz.Name == CurrentGroup.Name);
                if (modules != null)

                    if (IsInDesignMode)
                    {
                        foreach (Module m in modules)
                        {
                            Module m1 = m;
                            Module existinmodule = g.Modules.FirstOrDefault(gm => gm.Domain == m1.Domain && gm.Address == m1.Address);

                            if (existinmodule != null)
                            {
                                existinmodule.Name = m.Name;
                                existinmodule.Properties = m.Properties;
                            }
                            else
                            {
                                g.Modules.Add(m);
                            }
                            InstantiateModule(m);
                        }
                    }
                    else
                    {
                        DispatcherHelper.CheckBeginInvokeOnUI(() =>
                        {
                            foreach (Module m in modules)
                            {
                                AddModuleToGroup(m, g);
                            }
                        });
                    }

            });
        }

        private void AddModuleToGroup(Module module, Group group)
        {
            Module existinmodule = group.Modules.FirstOrDefault(gm => gm.Domain == module.Domain && gm.Address == module.Address);

            if (existinmodule != null)
            {
                existinmodule.Name = module.Name;
                existinmodule.Properties = module.Properties;
            }
            else
            {
                group.Modules.Add(module);
            }
            InstantiateModule(module);
        }

        private void InstantiateModule(Module module)
        {
            switch (module.DeviceType)
            {
                case Module.DeviceTypes.Dimmer:
                    ModulesForCurrentGroup.Add(new DimmerViewModel { Module = module, Group = CurrentGroup });
                    break;
                case Module.DeviceTypes.Program:
                    ModulesForCurrentGroup.Add(new ProgramViewModel { Module = module, Group = CurrentGroup });
                    break;
                case Module.DeviceTypes.Switch:
                    ModulesForCurrentGroup.Add(new SwitchViewModel { Module = module, Group = CurrentGroup });
                    break;
            }
        }
    }
}