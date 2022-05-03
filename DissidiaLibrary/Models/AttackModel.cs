using DissidiaLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dissidia012Library.Models
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
