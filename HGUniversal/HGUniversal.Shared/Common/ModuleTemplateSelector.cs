﻿using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Cimbalino.Toolkit.Extensions;
using HGUniversal.ViewModel.Controls;

namespace HGUniversal.Common
{
    public class ModuleTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DimmerTemplate { get; set; }
        public DataTemplate SwitchTemplate { get; set; }
        public DataTemplate ColorLightTemplate { get; set; }
        public DataTemplate ProgramTemplate { get; set; }
        public DataTemplate WidgetTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var module = item as IModuleVM;
            if (module is IDimmerVM)
            {
                return SelectDimmerTemplate(module);
            }

            if (module is IProgramVM)
            {
                return SelectProgramTemplate(module);
            }

            if (module is ISwitchVM)
            {
                return SwitchTemplate;
            }

            return base.SelectTemplateCore(item, container);
        }

        private DataTemplate SelectDimmerTemplate(IModuleVM module)
        {
            var properties = module.Module.Properties.FirstOrDefault(
                p => p.Name == "Widget.DisplayModule" && (p.Value == "" || p.Value == "homegenie/generic/colorlight"));

            return properties == null ? DimmerTemplate : ColorLightTemplate;
        }

        private DataTemplate SelectProgramTemplate(IModuleVM module)
        {
            var properties = module.Module.Properties.FirstOrDefault(
                p => p.Name == "Widget.DisplayModule" && (p.Value == "" || p.Value == "homegenie/generic/program"));

            return properties == null ? WidgetTemplate : ProgramTemplate;
        }
    }
}