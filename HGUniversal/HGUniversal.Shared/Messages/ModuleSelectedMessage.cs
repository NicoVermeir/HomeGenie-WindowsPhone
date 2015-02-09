using GalaSoft.MvvmLight.Messaging;
using HomeGenie.SDK.Objects;

namespace HGUniversal.Messages
{
    public class ModuleSelectedMessage : MessageBase
    {
        public string ModuleName { get; set; }
        public Group SelectedGroup { get; set; }
        public bool FromSecondaryTile { get; set; }

        public ModuleSelectedMessage(string moduleName, Group selectedGroup, bool fromSecondaryTile)
        {
            ModuleName = moduleName;
            SelectedGroup = selectedGroup;
            FromSecondaryTile = fromSecondaryTile;
        }
    }
}
