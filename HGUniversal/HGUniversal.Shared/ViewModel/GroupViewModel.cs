using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using Windows.UI.StartScreen;
using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using HGUniversal.Messages;
using HGUniversal.View;
using HGUniversal.ViewModel.Controls;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;
using RelayCommand = HGUniversal.Common.RelayCommand;

namespace HGUniversal.ViewModel
{
    public class GroupViewModel : HomeGenieViewModelBase
    {
        private readonly IHomeGenieApi _api;
        private readonly INavigationService _navigationService;

        private ICommand _pinGroupCommand;
        private ICommand _pinModuleCommand;
        private Group _selectedGroup;

        public ICommand PinGroupCommand
        {
            get { return _pinGroupCommand ?? (_pinGroupCommand = new RelayCommand(() => PinGroupTile())); }
        }

        public ICommand PinModuleCommand
        {
            get { return _pinModuleCommand ?? (_pinModuleCommand = new RelayCommand(() => PinModuleTile())); }
        }

        private RelayCommand<IModuleVM> _moduleSelectedCommand;
        public RelayCommand<IModuleVM> ModuleSelectedCommand
        {
            get
            {
                return _moduleSelectedCommand ?? (_moduleSelectedCommand = new RelayCommand<IModuleVM>(mod =>
                {
                    CurrentModule = mod;
                    if (CurrentModule.Module.DeviceType == Module.DeviceTypes.Program)
                    {
                        PopToast(string.Format("Executing {0}", CurrentModule.Module.Name));
                        _api.RunProgram(CurrentModule.Module, SelectedGroup);
                    }
                    else
                    {
                        _navigationService.Navigate<ModulePage>();
                    }
                }));
            }
        }

        private IModuleVM _currentModule;
        public IModuleVM CurrentModule
        {
            get { return _currentModule; }
            set
            {
                if (Set(() => CurrentModule, ref _currentModule, value))
                {
#if WINDOWS_PHONE_APP
                    ToggleAppBarButton(!SecondaryTile.Exists(_currentModule.Module.Name));
#endif
                }
            }
        }

        public ObservableCollection<IModuleVM> ModulesForCurrentGroup { get; set; }

        public Group SelectedGroup
        {
            get
            {
                return _selectedGroup;
            }
            set
            {
                if (Set(() => SelectedGroup, ref _selectedGroup, value))
                {
                    InstantiateModules();
#if WINDOWS_PHONE_APP
                    ToggleAppBarButton(!SecondaryTile.Exists(SelectedGroup.Name.ToString()));
#endif
                }
            }
        }

        private void InstantiateModules()
        {
            ModulesForCurrentGroup.Clear();
            foreach (Module module in SelectedGroup.Modules)
            {
                InstantiateModule(module);
            }
        }

        public GroupViewModel(IHomeGenieApi api, INavigationService navigationService)
        {
            _api = api;
            _navigationService = navigationService;
            ModulesForCurrentGroup = new ObservableCollection<IModuleVM>();

            if (IsInDesignModeStatic)
            {
                SetDesignTimeData();
            }

            MessengerInstance.Register<GroupSelectedMessage>(this, async msg =>
            {
                SelectedGroup = msg.Group;

                if (msg.FromSecondaryTile)
                    await LoadModulesForGroup();

                InstantiateModules();
            });

            MessengerInstance.Register<ModuleSelectedMessage>(this, async msg =>
            {
                SelectedGroup = msg.SelectedGroup;

                if (msg.FromSecondaryTile)
                    await LoadModulesForGroup();

                InstantiateModules();

                CurrentModule = ModulesForCurrentGroup.FirstOrDefault(moduleVM => moduleVM.Module.Name == msg.ModuleName);
            });
        }

        private async Task LoadModulesForGroup()
        {
            if (SelectedGroup.Modules == null)
                SelectedGroup.Modules = new List<Module>();

            SelectedGroup.Modules = await _api.LoadGroupModules(SelectedGroup.Name);
            RaisePropertyChanged(() => SelectedGroup);
        }

        private void InstantiateModule(Module module)
        {
            switch (module.DeviceType)
            {
                case Module.DeviceTypes.Dimmer:
                    ModulesForCurrentGroup.Add(new DimmerViewModel { Module = module, Group = SelectedGroup });
                    break;
                case Module.DeviceTypes.Program:
                    ModulesForCurrentGroup.Add(new ProgramViewModel { Module = module, Group = SelectedGroup });
                    break;
                case Module.DeviceTypes.Switch:
                    ModulesForCurrentGroup.Add(new SwitchViewModel { Module = module, Group = SelectedGroup });
                    break;
                case Module.DeviceTypes.Sensor:
                    ModulesForCurrentGroup.Add(new SensorViewModel { Module = module, Group = SelectedGroup });
                    break;
                case Module.DeviceTypes.Temperature:
                    ModulesForCurrentGroup.Add(new TemperatureViewModel { Module = module, Group = SelectedGroup });
                    break;
                case Module.DeviceTypes.Shutter:
                    ModulesForCurrentGroup.Add(new ShutterViewModel { Module = module, Group = SelectedGroup });
                    break;
            }
        }

        private void SetDesignTimeData()
        {
            SelectedGroup = new Group { Name = "Design group" };

            Module dimmer = new Module { Name = "Staanlamp", DeviceType = Module.DeviceTypes.Dimmer };
            Module dimmer2 = new Module { Name = "Staanlamp 2", DeviceType = Module.DeviceTypes.Dimmer };
            Module dimmer3 = new Module { Name = "Staanlamp 3", DeviceType = Module.DeviceTypes.Dimmer };

            InstantiateModule(dimmer);
            InstantiateModule(dimmer2);
            InstantiateModule(dimmer3);
        }

        private async Task PinGroupTile()
        {
            bool isPinned = true;

            if (SecondaryTile.Exists(SelectedGroup.Name))
            {
                SecondaryTile secondaryTile = new SecondaryTile(SelectedGroup.Name);
                await secondaryTile.RequestDeleteAsync();

                isPinned = false;
            }
            else
            {
                SecondaryTile secondaryTile = new SecondaryTile(SelectedGroup.Name, SelectedGroup.Name, SelectedGroup.Name, new Uri("ms-appx:///Assets/Logo.png"), TileSize.Default) { Arguments = "group", ForegroundText = ForegroundText.Light, TileOptions = TileOptions.ShowNameOnLogo };
                await secondaryTile.RequestCreateForSelectionAsync(new Rect(), Placement.Above);

                UpdateTile(SelectedGroup.Name, SelectedGroup.GroupTemperature.ToString(), SelectedGroup.GroupLuminance.ToString());
            }

            ToggleAppBarButton(!isPinned);

            //register backgroundtask
            await RegisterTask();
        }

        private async Task PinModuleTile()
        {
            bool isPinned = true;

            if (SecondaryTile.Exists(CurrentModule.Module.Name))
            {
                SecondaryTile secondaryTile = new SecondaryTile(CurrentModule.Module.Name);
                await secondaryTile.RequestDeleteAsync();

                isPinned = false;
            }
            else
            {
                string args = string.Format("module|{0}", SelectedGroup.Name);

                SecondaryTile secondaryTile = new SecondaryTile(CurrentModule.Module.Name, CurrentModule.Module.Name, CurrentModule.Module.Name, new Uri("ms-appx:///Assets/Logo.png"), TileSize.Default) { Arguments = args, ForegroundText = ForegroundText.Light, TileOptions = TileOptions.ShowNameOnLogo };
                await secondaryTile.RequestCreateForSelectionAsync(new Rect(), Placement.Above);

                //UpdateTile(CurrentModule.Module.Name, SelectedGroup.GroupTemperature.ToString(), SelectedGroup.GroupLuminance.ToString());
            }

            ToggleAppBarButton(!isPinned);

            //register backgroundtask
            await RegisterTask();
        }

        private void UpdateTile(string tileId, string temp, string luminance)
        {
            var updater = TileUpdateManager.CreateTileUpdaterForSecondaryTile(tileId);
            updater.Clear();

            XmlDocument tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150PeekImageAndText02);

            tileXml.GetElementsByTagName("image")[0].Attributes.First(a => a.NodeName == "src").NodeValue = "ms-appx:///Assets/Logo.png";

            if (!string.IsNullOrWhiteSpace(temp))
                tileXml.GetElementsByTagName("text")[0].InnerText = string.Format("Temp {0}°", temp);

            if (!string.IsNullOrWhiteSpace(luminance))
                tileXml.GetElementsByTagName("text")[1].InnerText = string.Format("luminance {0}", luminance);

            // Create a new tile notification. 
            updater.Update(new TileNotification(tileXml));
        }
    }
}
