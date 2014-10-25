using System.Windows.Controls;
using HomeGenie.SDK.Objects;
using HomeGenie.ViewModel.Controls;

namespace HomeGenie.Controls
{
    public partial class ProgramModuleControl : UserControl
    {
        public ProgramModuleControl()
        {
            InitializeComponent();
            Loaded += (sender, args) =>
            {
                DataContext = new DimmerViewModel();
            };
        }

        private Module GetModule()
        {
            return DataContext as Module;
        }
    }
}
