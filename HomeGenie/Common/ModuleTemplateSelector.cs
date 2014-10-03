﻿using System.Windows;
using HomeGenie.SDK.Objects;

namespace HomeGenie.Common
{
    public class ModuleTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DimmerTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Module module = item as Module;

            if (module == null)
                return null;

            switch (module.DeviceType)
            {
                case Module.DeviceTypes.Dimmer:
                    return DimmerTemplate;
                case Module.DeviceTypes.Program:
                    return DimmerTemplate;
                default:
                    return null;
            }
        }
    }
}