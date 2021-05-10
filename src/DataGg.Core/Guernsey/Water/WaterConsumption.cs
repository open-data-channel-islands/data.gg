using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Water
{
    class WaterConsumption
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Metered")]
        public long Metered { get; set; }

        [JsonPropertyName("Unmetered")]
        public long Unmetered { get; set; }

        [JsonPropertyName("Commercial")]
        public long? Commercial { get; set; }

        [JsonPropertyName("Other")]
        public long Other { get; set; }

        [JsonPropertyName("Total")]
        public long Total { get; set; }

        [JsonPropertyName("Comm  ")]
        public long? WelcomeComm { get; set; }

        [JsonPropertyName("Comm ")]
        public long? Comm { get; set; }
    }
}
