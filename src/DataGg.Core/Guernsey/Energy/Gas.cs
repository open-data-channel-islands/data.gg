using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.energy
{
    public class Gas
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Mains Gas")]
        public long MainsGas { get; set; }

        [JsonPropertyName("Bottled Gas")]
        public long BottledGas { get; set; }

        [JsonPropertyName("Total")]
        public long Total { get; set; }
    }
}
