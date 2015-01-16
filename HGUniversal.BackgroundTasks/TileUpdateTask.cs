using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using Windows.UI.StartScreen;
using HomeGenie.SDK;
using HomeGenie.SDK.Objects;

namespace HGUniversal.BackgroundTasks
{
    public sealed class TileUpdateTask : IBackgroundTask
    {
        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            var deferral = taskInstance.GetDeferral();
            IHomeGenieApi api = new HomeGenieApi();
            IReadOnlyList<SecondaryTile> tiles = await GetSecondaryTiles();

            try
            {
                foreach (SecondaryTile tile in tiles)
                {
                    List<Module> modules = await api.LoadGroupModules(tile.TileId);
                    double? temp = FindGroupTemperature(modules);
                    double? luminance = FindGroupLuminance(modules);

                    string tempString = temp.HasValue ? temp.Value.ToString() : string.Empty;
                    string luminanceString = luminance.HasValue ? luminance.Value.ToString() : string.Empty;

                    UpdateTile(tile.TileId, tempString, luminanceString);
                }
            }
            catch (Exception)
            {
                //TODO: logging
            }
            finally
            {
                deferral.Complete();                
            }
        }

        private async Task<IReadOnlyList<SecondaryTile>> GetSecondaryTiles()
        {
            return await SecondaryTile.FindAllForPackageAsync();
        }

        private void UpdateTile(string tileId, string temp, string luminance)
        {
            var updater = TileUpdateManager.CreateTileUpdaterForSecondaryTile(tileId);
            updater.Clear();

            XmlDocument tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150PeekImageAndText02);

            string text = string.Format("Temp: {0}", temp);
            tileXml.GetElementsByTagName("image")[0].Attributes.First(a => a.NodeName == "src").NodeValue = "ms-appx:///Assets/Logo.png";

            if (!string.IsNullOrWhiteSpace(temp))
                tileXml.GetElementsByTagName("text")[0].InnerText = string.Format("{0}°", temp);

            if (!string.IsNullOrWhiteSpace(luminance))
                tileXml.GetElementsByTagName("text")[1].InnerText = string.Format("luminance {0}", luminance);

            // Create a new tile notification. 
            updater.Update(new TileNotification(tileXml));
        }

        private double? FindGroupTemperature(List<Module> modules)
        {
            double temperature;

            //get all modules in the current group that have a temperature sensor
            var temperatureSensors = from module in modules
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

        private double? FindGroupLuminance(List<Module> modules)
        {
            double luminance;

            //get all modules in the current group that have a temperature sensor
            var luminanceSensors = from module in modules
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
    }
}
