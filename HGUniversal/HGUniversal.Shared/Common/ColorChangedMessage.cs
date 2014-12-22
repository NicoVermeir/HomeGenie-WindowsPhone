using Windows.UI;
using GalaSoft.MvvmLight.Messaging;

namespace HGUniversal.Common
{
    public class ColorChangedMessage : MessageBase
    {
        public Color SelectedColor { get; set; }

        public ColorChangedMessage(Color selectedColor)
        {
            SelectedColor = selectedColor;
        }
    }
}
