using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissidiaLibrary.Models
{
    public class CharacterModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        [JsonProperty(PropertyName ="Name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName ="Description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName ="Attacks")]
        public List<AttackModel> Attacks { get; set; } = new List<AttackModel>();
        [JsonProperty(PropertyName ="builds")]
        public List<BuildModel> Builds { get; set; } = new List<BuildModel>();
        [JsonProperty(PropertyName ="commonStrategy")]
        public string CommonStrategy { get; set; }
        [JsonProperty(PropertyName ="videos")]
        public List<string> Videos { get; set; } = new List<string>();
    }
}
