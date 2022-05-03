using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissidiaLibrary.Models
{
    public class MatchupAnalysisModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; } = new Guid();
        public MatchupCharacterModel Character1 { get; set; }
        public MatchupCharacterModel Character2 { get; set; }
        public string MatchupValue { get; set; }
        public string MatchupAnalysis { get; set; }

    }
}
