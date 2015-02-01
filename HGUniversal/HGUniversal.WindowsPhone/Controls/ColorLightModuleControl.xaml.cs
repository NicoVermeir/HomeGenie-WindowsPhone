using Windows.UI;
using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight.Messaging;
using HGUniversal.Common;

namespace HGUniversal.Controls
{
    public partial class ColorLightModuleControl : UserControl
    {
        public ColorLightModuleControl()
        {
            InitializeComponent();
        }

        private void ColorPicker_OnColorChanged(object sender, Color color)
        {
            Messenger.Default.Send(new ColorChangedMessage(color));
        }
    }
}
