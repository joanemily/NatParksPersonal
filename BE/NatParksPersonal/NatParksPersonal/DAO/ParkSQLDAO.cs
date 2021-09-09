
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;
using System.Linq;
using System.Threading.Tasks;
using NatParksPersonal.Models;
using System.Net.Http;

namespace NatParksPersonal.DAO
{
    public class ParkSqlDAO : IParkDAO
    {
        private readonly string connectionString;

        public ParkSqlDAO(string dbConnectionString)
        {
            this.connectionString = dbConnectionString;
        }

        public List<park> GetParks()
        {
            List<park> parks = new List<park>();

            string url = "https://developer.nps.gov/api/v1/parks?limit=467&api_key=YUFrhPwJQlguj4qDAV5EmruP2sQ7noYXzXVIdyIs";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            var data = JsonConvert.DeserializeObject<List<park>>(response);

            
            foreach(park in parks)
            {
                string id = park.parkID;
                string fullName = park.parkFullName;
                string parkCode = park.parkCode;
                string url = park.parkURL;

                

            }

            return parks;
        }
    }
}
