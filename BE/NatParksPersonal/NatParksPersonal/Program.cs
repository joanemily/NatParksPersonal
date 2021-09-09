using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using WebAPIClient;

namespace NatParksPersonal
{
    public class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            var repositories = await ProcessParks();

            foreach (var repo in repositories)
                Console.WriteLine(repo.Name);
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static async Task<List<park>> ProcessParks()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
                //new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            //client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://developer.nps.gov/api/v1/parks?limit=467&api_key=YUFrhPwJQlguj4qDAV5EmruP2sQ7noYXzXVIdyIs");
            var parks = await JsonSerializer.DeserializeAsync<List<park>>(await streamTask);

            return parks;

        }


    }
}
