using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatParksPersonal.Models
{
    public class hour
    {
        public Dictionary<string, string> exceptionHours { get; set; }
        public DateTime exceptionStartDate { get; set; }
        public DateTime exceptionEndDate { get; set; }
        public string exceptionName { get; set; }
        public Dictionary<string, string> standardHours { get; set; }
        public string hourName { get; set; }
        public string hourDescription { get; set; }
        public park hourPark { get; set; }
    }
}
