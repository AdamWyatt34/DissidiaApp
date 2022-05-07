using DissidiaWebUI.Models.Enums;

namespace DissidiaWebUI.Models
{
    public class AttackModel
    {
        public AttackType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Frames { get; set; }
        public PriorityType Priority { get; set; }
    }
}
