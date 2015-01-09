using GalaSoft.MvvmLight.Messaging;
using HomeGenie.SDK.Objects;

namespace HGUniversal.Messages
{
    public class GroupSelectedMessage : MessageBase
    {
        public Group Group { get; set; }
        public bool FromSecondaryTile { get; set; }

        public GroupSelectedMessage(Group selectedGroup)
            :this(selectedGroup, false)
        {
        }

        public GroupSelectedMessage(Group selectedGroup, bool fromSecondaryTile)
        {
            Group = selectedGroup;
            FromSecondaryTile = fromSecondaryTile;
        }
    }
}
