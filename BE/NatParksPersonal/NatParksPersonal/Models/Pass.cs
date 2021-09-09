using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatParksPersonal.Models
{
    public class pass
    {
        public decimal passCost { get; set; }
        public string passDescription { get; set; }
        public string passTitle { get; set; }
        public park passPark { get; set; }

    }
}
