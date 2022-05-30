using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissidiaLibrary.Models
{
    public interface IGuid
    {
        [JsonProperty(PropertyName = "id")]
        Guid Id { get; set; }
    }
}
