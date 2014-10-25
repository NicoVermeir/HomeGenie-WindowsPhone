using HomeGenie.SDK.Objects;

namespace HomeGenie.ViewModel.Controls
{
    public interface IModuleVM
    {
        Module Module { get; set; }
        Group Group { get; set; }
    }
}