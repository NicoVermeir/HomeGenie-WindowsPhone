using System.Windows.Controls;
using HomeGenie.SDK.Objects;
using HomeGenie.ViewModel.Controls;

namespace HomeGenie.Controls
{
    public partial class DimmerModuleControl : UserControl
    {
        public DimmerModuleControl()
        {
            InitializeComponent();

            Loaded += (sender, args) =>
            {
                DataContext = new DimmerViewModel(GetModule());
            };
        }

        private Module GetModule()
        {
            return DataContext as Module;
        }
    }
}
