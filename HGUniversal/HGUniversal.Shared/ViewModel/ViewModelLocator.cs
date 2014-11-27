using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using HomeGenie.SDK;
using HomeGenie.SDK.Contracts;
using HomeGenie.SDK.Http;
using HomeGenie.SDK.Services;
using Microsoft.Practices.ServiceLocation;

namespace HGUniversal.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
                //SimpleIoc.Default.Register<IHomeGenieApi, HomeGenieDesignTimeApi>();
                //SimpleIoc.Default.Register<ISettingsService, SettingsDesignTimeService>();
            }
            else
            {
                // Create run time view services and models
                SimpleIoc.Default.Register<IHomeGenieApi, HomeGenieApi>();
                SimpleIoc.Default.Register<HTTPRequestQueue>();
                SimpleIoc.Default.Register<ISettingsService, SettingsService>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}