using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;
using HGUniversal.Messages;
using HGUniversal.View;
using HomeGenie.Common;
using HomeGenie.SDK;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Objects;

namespace HGUniversal.ViewModel
{
    public class MainViewModel : HomeGenieViewModelBase
    {
#if WINDOWS_APP
        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            set { Set(ref _isOpen, value); }
        }

        private RelayCommand<Module> _moduleSelectedCommand;
        public RelayCommand<Module> ModuleSelectedCommand
        {
            get
            {
                return _moduleSelectedCommand ?? (_moduleSelectedCommand = new RelayCommand<Module>(module =>
                {
                    Group group = Items.FirstOrDefault(g => g.Modules.Contains(module));
                    if (module.DeviceType == Module.DeviceTypes.Program)
                    {
                        _api.RunProgram(module, group);
                        return;
                    }
                    IsOpen = true;
                    MessengerInstance.Send(new ModuleSelectedMessage(module.Name, group, false));
                }));
            }
        }
#endif
        private readonly IHomeGenieApi _api;
        private readonly INavigationService _navigationService;
        private readonly ISettingsService _settingsService;

        public ObservableCollection<Group> Items { get; private set; }

        private ObservableCollection<GroupInfoList<object>> _groupedItems;
        public ObservableCollection<GroupInfoList<object>> GroupedItems
        {
            get { return _groupedItems; }
            set { Set(ref _groupedItems, value); }
        }

        private RelayCommand<Group> _groupSelectedCommand;

        public RelayCommand<Group> GroupSelectedCommand
        {
            get
            {
                return _groupSelectedCommand ?? (_groupSelectedCommand = new RelayCommand<Group>(group =>
                {
                    _navigationService.Navigate<GroupPage>();
                    MessengerInstance.Send(new GroupSelectedMessage(group));
                }));
            }
        }

        public MainViewModel(IHomeGenieApi api,
            INavigationService navigationService,
            ISettingsService settingsService)
        {
            _api = api;
            _navigationService = navigationService;
            _settingsService = settingsService;

            Items = new ObservableCollection<Group>();

            StateContainer.ConnectionUpdated += async (sender, args) => await LoadData();
            Task.Run(() => LoadData());
        }

        public async Task LoadData()
        {
            //IsDataLoading = true;

            if (!_settingsService.DoesSettingExist(Constants.ServerAddressSetting))
            {
                //just making sure the DispatcherHelper is initialized
                await Task.Delay(300);

                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                _navigationService.Navigate<ConnectionPage>());
            }
            else
            {
                try
                {
                    await LoadGroups();

                    //wait for bindings to update, this is necessary
                    await Task.Delay(100);

                    await LoadGroupModules();

#if WINDOWS_APP
                    GroupItems();
#endif

#if !DUMMY
                    StateContainer.Connect();
#endif
                }
                catch (Exception)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI(() => _navigationService.Navigate<ConnectionPage>());

                }
            }
        }

        private async Task LoadGroups()
        {
            try
            {
                IList<Group> groups = await _api.LoadGroups();
                await Task.Delay(300);
                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    Items.Clear();
                    foreach (Group g in groups)
                    {
                        Items.Add(g);
                    }
                    IsDataLoading = false;
                });
            }
            catch (LoadDataError)
            {
                //TODO: show error
                var d = new MessageDialog("error");
                d.ShowAsync();
            }
        }

        private void GroupItems()
        {
            if (GroupedItems == null)
            {
                DispatcherHelper.CheckBeginInvokeOnUI(() => GroupedItems = new ObservableCollection<GroupInfoList<object>>());
            }
            else
            {
                GroupedItems.Clear();
            }

            var groups = from item in Items
                         orderby item.Name
                         group item by item.Name into g
                         select new { GroupName = g.Key, Items = g };

            foreach (var group in groups)
            {
                GroupInfoList<object> info = new GroupInfoList<object> { Key = group.GroupName };

                foreach (var item in group.Items)
                {
                    info.AddRange(item.Modules);
                }

                DispatcherHelper.CheckBeginInvokeOnUI(() => GroupedItems.Add(info));
            }
        }

        internal async Task LoadGroupModules()
        {
            //ToList because http://stackoverflow.com/questions/604831/collection-was-modified-enumeration-operation-may-not-execute
            foreach (Group item in Items.ToList())
            {
                if (item.Modules == null)
                    item.Modules = new List<Module>();

                item.Modules = await _api.LoadGroupModules(item.Name);

                var item1 = item;
                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    item1.GroupTemperature = FindGroupTemperature(item1);
                    item1.GroupLuminance = FindGroupLuminance(item1);
                    item1.GroupHumidity = FindGroupHumidity(item1);

                    item1.NumberOfLights = CountGroupLights(item1);
                    item1.NumberOfSwitches = CountGroupSwitches(item1);
                });
            }
        }

        private double? FindGroupTemperature(Group currentGroup)
        {
            double temperature;

            //get all modules in the current group that have a temperature sensor
            var temperatureSensors = from module in currentGroup.Modules
                                     where module.Properties.Any(prop => prop.Name == Constants.TemperatureSensorName)
                                     select module;

            Module temperatureModule = temperatureSensors.FirstOrDefault();

            if (temperatureModule == null)
                return null;

            //get the temperature sensor
            ModuleParameter temperatureSensor = temperatureModule
                    .Properties.FirstOrDefault(prop => prop.Name == Constants.TemperatureSensorName);

            if (double.TryParse(temperatureSensor.Value, out temperature))
                return temperature;

            return null;
        }

        private double? FindGroupLuminance(Group currentGroup)
        {
            double luminance;

            //get all modules in the current group that have a temperature sensor
            var luminanceSensors = from module in currentGroup.Modules
                                   where module.Properties.Any(prop => prop.Name == Constants.LuminanceSensorName)
                                   select module;

            Module luminanceModule = luminanceSensors.FirstOrDefault();

            if (luminanceModule == null)
                return null;

            //get the temperature sensor
            ModuleParameter luminanceSensor = luminanceModule
                    .Properties.FirstOrDefault(prop => prop.Name == Constants.LuminanceSensorName);

            if (double.TryParse(luminanceSensor.Value, out luminance))
                return luminance;

            return null;
        }

        private double? FindGroupHumidity(Group currentGroup)
        {
            double humidity;

            //get all modules in the current group that have a temperature sensor
            var humiditySensors = from module in currentGroup.Modules
                                  where module.Properties.Any(prop => prop.Name == Constants.HumiditySensorName)
                                  select module;

            Module humidityModule = humiditySensors.FirstOrDefault();

            if (humidityModule == null)
                return null;

            //get the temperature sensor
            ModuleParameter humiditySensor = humidityModule
                    .Properties.FirstOrDefault(prop => prop.Name == Constants.HumiditySensorName);

            if (double.TryParse(humiditySensor.Value, out humidity))
                return humidity;

            return null;
        }

        public int CountGroupLights(Group currentGroup)
        {
            return currentGroup.Modules.Count(
                module =>
                    module.DeviceType == Module.DeviceTypes.Light || module.DeviceType == Module.DeviceTypes.Dimmer);
        }

        public int CountGroupSwitches(Group currentGroup)
        {
            return currentGroup.Modules.Count(
                module =>
                    module.DeviceType == Module.DeviceTypes.Switch);
        }
    }
}