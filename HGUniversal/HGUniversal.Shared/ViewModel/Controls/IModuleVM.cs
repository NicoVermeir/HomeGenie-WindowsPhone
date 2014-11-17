using HomeGenie.SDK.Objects;

namespace HGUniversal.ViewModel.Controls
{
    public interface IModuleVM
    {
        Module Module { get; set; }
        Group Group { get; set; }
    }
}