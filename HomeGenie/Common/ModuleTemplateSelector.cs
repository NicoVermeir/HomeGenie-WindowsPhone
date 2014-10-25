using System.Windows;
using HomeGenie.ViewModel.Controls;

namespace HomeGenie.Common
{
    public class ModuleTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DimmerTemplate { get; set; }
        public DataTemplate ProgramTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var module = item as IModuleVM;

            if (module is IDimmerVM)
            {
                return DimmerTemplate;
            }

            if (module is IProgramVM)
            {
                return ProgramTemplate;
            }

            return null;
        }
    }
}