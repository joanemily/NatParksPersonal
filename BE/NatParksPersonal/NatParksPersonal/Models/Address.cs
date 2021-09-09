using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatParksPersonal.Models
{
    public class address
    {
        public park addressPark { get; set; }
        public int addressPostalCode { get; set; }
        public string addressCity { get; set; }
        public string addressStateCode { get; set; }
        public string addressLine1 { get; set; }
        public string addressType { get; set; }
        public string addressLine3 { get; set; }
        public string addressLine2 { get; set; }

    }
}
