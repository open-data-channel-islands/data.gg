using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Population
{
    public class Parish
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Castel")]
        public long Castel { get; set; }

        [JsonPropertyName("Forest")]
        public long Forest { get; set; }

        [JsonPropertyName("St. Andrew")]
        public long StAndrew { get; set; }

        [JsonPropertyName("St. Martin")]
        public long StMartin { get; set; }

        [JsonPropertyName("St. Peter Port")]
        public long StPeterPort { get; set; }

        [JsonPropertyName("St. Pierre Du Bois")]
        public long StPierreDuBois { get; set; }

        [JsonPropertyName("St. Sampson")]
        public long StSampson { get; set; }

        [JsonPropertyName("St. Saviour")]
        public long StSaviour { get; set; }

        [JsonPropertyName("Torteval")]
        public long Torteval { get; set; }

        [JsonPropertyName("Vale")]
        public long Vale { get; set; }

        [JsonPropertyName("Herm and Jethou")]
        public long HermAndJethou { get; set; }

        [JsonPropertyName("Address unknown")]
        public long AddressUnknown { get; set; }
    }
}
