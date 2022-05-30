using System.ComponentModel.DataAnnotations;

namespace DissidiaWebUI.Models
{
    public class BuildModel
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}
