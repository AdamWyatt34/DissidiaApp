using DissidiaWebUI.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace DissidiaWebUI.Models
{
    public class AttackModel
    {
        [Required]
        public AttackType Type { get; set; } = AttackType.Bravery;
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Frames { get; set; }
        [Required]
        public PriorityType Priority { get; set; } = PriorityType.RangedLow;
    }
}
