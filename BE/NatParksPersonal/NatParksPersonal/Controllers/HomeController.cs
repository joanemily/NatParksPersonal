using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NatParksPersonal.Models;


namespace NatParksPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public interface IParkDAO
        {
            IList<park> GetParks();
            park GetParkByCode(string parkCode);
        }
    }
}
