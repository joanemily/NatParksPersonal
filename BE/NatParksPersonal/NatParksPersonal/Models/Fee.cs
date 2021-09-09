using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatParksPersonal.Models
{
    public class fee
    {
        public decimal feeCost { get; set; }
        public string feeDescription { get; set; }
        public string feeTitle { get; set; }
        public park feePark { get; set; }

    }
}
