using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HGUniversal.Controls
{
    public sealed partial class ImageTextbox : UserControl
    {
        private static event EventHandler<bool> ToggleVisibility;

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text", typeof(string), typeof(ImageTextbox), new PropertyMetadata(default(string), TextChangedCallback));

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
            "ImageSource", typeof(string), typeof(ImageTextbox), new PropertyMetadata(default(string)));

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public ImageTextbox()
        {
            InitializeComponent();

            ToggleVisibility += (sender, b) =>
            {
                Visibility = b ? Visibility.Visible : Visibility.Collapsed;
            };
        }

        private static void TextChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            if (string.IsNullOrWhiteSpace(dependencyPropertyChangedEventArgs.NewValue as string))
            {
                if (ToggleVisibility != null) ToggleVisibility(null, false);
            }
            else
            {
                if (ToggleVisibility != null) ToggleVisibility(null, true);
            }
        }
    }
}
