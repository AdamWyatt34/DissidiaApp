﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissidiaLibrary.Models
{
    public class MatchupCharacterModel : IGuid
    {
        public Guid Id { get; set; }
        public string Strategy { get; set; }
    }
}
