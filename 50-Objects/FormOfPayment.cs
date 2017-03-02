using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class FormOfPayment
    {
        //private string _code;
        //private string _name;

        [DisplayName("Código")]
        public string Code { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
    }
}
