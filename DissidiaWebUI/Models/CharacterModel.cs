using System.ComponentModel.DataAnnotations;

namespace DissidiaWebUI.Models
{
    public class CharacterModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public List<AttackModel> Attacks { get; set; } = new List<AttackModel>();
        public List<BuildModel> Builds { get; set; } = new List<BuildModel>();
        public string CommonStrategy { get; set; }
        public List<string> Videos { get; set; } = new List<string>();
    }
}
