using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DissidiaWebUI.Models.Enums
{
    public enum PriorityType
    {
        [Description("Ranged Low")]
        RangedLow,
        [Description("Melee Low")]
        MeleeLow,
        [Description("Ranged Mid")]
        RangedMid,
        [Description("Melee Mid")]
        MeleeMid,
        [Description("Ranged High")]
        RangedHigh,
        [Description("Melee High")]
        MeleeHigh,
        [Description("Special")]
        Special,
        [Description("Unblockable")]
        Unblockable,
        [Description("Block Low")]
        BlockLow,
        [Description("Block Mid")]
        BlockMid,
        [Description("Block High")]
        BlockHigh,
        [Description("Jecht Block")]
        JechtBlock,
        [Description("Block Highest")]
        BlockHighest,
        [Description("Shell Guard")]
        ShellGuard,
        [Description("Protect Guard")]
        ProtectGuard
    }
}
