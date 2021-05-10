using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Waste
{
    class ConstructionAndDemolition
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Land Reclamation")]
        public double LandReclamation { get; set; }

        [JsonPropertyName("Reused")]
        public double Reused { get; set; }

        [JsonPropertyName("Landfill")]
        public double Landfill { get; set; }

        [JsonPropertyName("Total")]
        public double Total { get; set; }
    }
}
