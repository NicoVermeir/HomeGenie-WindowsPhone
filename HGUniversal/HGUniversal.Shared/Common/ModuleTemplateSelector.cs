using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using HGUniversal.ViewModel.Controls;

namespace HGUniversal.Common
{
    public class ModuleTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DimmerTemplate { get; set; }
        public DataTemplate ProgramTemplate { get; set; }
        public DataTemplate WidgetTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var module = item as IModuleVM;

            if (module is IDimmerVM)
            {
                return DimmerTemplate;
            }

            if (module is IProgramVM)
            {
                return SelectProgramTemplate(module);
            }

            return base.SelectTemplateCore(item, container);
        }

        private DataTemplate SelectProgramTemplate(IModuleVM module)
        {
            var properties = module.Module.Properties.FirstOrDefault(
                p => p.Name == "Widget.DisplayModule" && (p.Value == "" || p.Value == "homegenie/generic/program"));

            return properties == null ? WidgetTemplate : ProgramTemplate;
        }
    }
}