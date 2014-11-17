// This code is licensed under a Creative Commons Attribution 3.0 Unported License. Any work that includes this code must provide attribution
// by means of a link. It is suggested that commercial applications that make use of code from this blog include a reference to the relevant blog post in their 'about' page.


using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;

namespace HGUniversal.MultiBinding
{
    /// <summary>
    /// Manages the construction of multiple MultiBinding instances
    /// </summary>
    [ContentProperty(Name = "Bindings")]
    public class MultiBindings : FrameworkElement
    {
        private FrameworkElement _targetElement;

        /// <summary>
        /// Gets / sets the collection of MultiBindings
        /// </summary>
        public ObservableCollection<MultiBinding> Bindings { get; set; }

        public MultiBindings()
        {
            Bindings = new ObservableCollection<MultiBinding>();
        }

        /// <summary>
        /// Sets the DataContext of each of the MultiBinding instances
        /// </summary>
        public void SetDataContext(object dataContext)
        {
            foreach (MultiBinding relay in Bindings)
            {
                relay.DataContext = dataContext;
            }
        }

        /// <summary>
        /// Initialises each of the MultiBindings, and binds their ConvertedValue
        /// to the given target property.
        /// </summary>
        public void Initialize(FrameworkElement targetElement)
        {
            _targetElement = targetElement;

            foreach (MultiBinding relay in Bindings)
            {
                relay.Initialise(targetElement);

                // find the target dependency property
                Type targetType = null;
                string targetProperty = null;

                // assume it is an attached property if the dot syntax is used.
                if (relay.TargetProperty.Contains("."))
                {
                    // split to find the type and property name
                    string[] parts = relay.TargetProperty.Split('.');
                    targetType = Type.GetType("System.Windows.Controls." + parts[0] +
                                              ", System.Windows, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
                    targetProperty = parts[1];
                }
                else
                {
                    targetType = targetElement.GetType();
                    targetProperty = relay.TargetProperty;
                }

                FieldInfo[] sourceFields = targetType.GetRuntimeFields().ToArray();
                FieldInfo targetDependencyPropertyField =
                    sourceFields.First(i => i.Name == targetProperty + "Property");
                var targetDependencyProperty =
                    targetDependencyPropertyField.GetValue(null) as DependencyProperty;

                // bind the ConvertedValue of our MultiBinding instance to the target property
                // of our targetElement
                var binding = new Binding
                {
                    Source = relay,
                    Mode = relay.Mode
                };
                targetElement.SetBinding(targetDependencyProperty, binding);
            }
        }
    }
}