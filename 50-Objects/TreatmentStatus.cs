using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class TreatmentStatus
    {
        [DisplayName("Identificador")]
        public byte Identifier { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }
    }
}
