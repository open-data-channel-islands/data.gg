using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.energy
{
    public class OilImports
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Transport")]
        public long Transport { get; set; }

        [JsonPropertyName("Heating-Electricity")]
        public long HeatingElectricity { get; set; }
    }
}
