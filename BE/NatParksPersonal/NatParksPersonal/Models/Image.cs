using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatParksPersonal.Models
{
    public class image
    {
        public string imageCredit { get; set; }
        public string imageTitle { get; set; }
        public string imageAltText { get; set; }
        public string imageCaption { get; set; }
        public string imageUrl { get; set; }
        public park imagePark { get; set; }
    }
}
