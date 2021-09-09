using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WebAPIClient
{
    public class park
    {
        [JsonPropertyName("id")]
        public string parkID { get; set; }

        [JsonPropertyName("fullName")]
        public string parkFullName { get; set; }

        [JsonPropertyName("parkCode")]
        public string parkCode { get; set; }

        [JsonPropertyName("description")]
        public string parkDescription { get; set; }

        [JsonPropertyName("latitude")]
        public string parkLatitude { get; set; }

        [JsonPropertyName("longitude")]
        public string parkLongitude { get; set; }

        [JsonPropertyName("states")]
        public string parkStates { get; set; }

        [JsonPropertyName("directionsInfo")]
        public string parkDirectionsInfo { get; set; }

        [JsonPropertyName("directionsUrl")]
        public string parkDirectionsURL { get; set; }

        [JsonPropertyName("weatherInfo")]
        public string parkWeatherInfo { get; set; }

        [JsonPropertyName("name")]
        public string parkName { get; set; }

        [JsonPropertyName("designation")]
        public string parkDesignation { get; set; }

        [JsonPropertyName("url")]
        public string parkURL { get; set; }

        [JsonPropertyName("activities")]
        public Dictionary<string, string> parkActivities { get; set; }

    }
}
