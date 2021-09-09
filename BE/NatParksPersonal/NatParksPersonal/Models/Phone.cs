using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatParksPersonal.Models
{
    public class phone
    {
        public int phoneNumber { get; set; }
        public string phoneDescription { get; set; }
        public int phoneExtension { get; set; }
        public string phoneType { get; set; }
        public park phonePark { get; set; }
    }
}
