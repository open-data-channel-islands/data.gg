using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Emissions
{
    public class Source
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Energy Power generation")]
        public double EnergyPowerGeneration { get; set; }

        [JsonPropertyName("Energy Industrial combustion")]
        public double EnergyIndustrialCombustion { get; set; }

        [JsonPropertyName("Energy Transport")]
        public double EnergyTransport { get; set; }

        [JsonPropertyName("Energy Commercial and domestic combusiton")]
        public double EnergyCommercialAndDomesticCombusiton { get; set; }

        [JsonPropertyName("Agricultural land use land use change and forestry")]
        public double AgriculturalLandUseLandUseChangeAndForestry { get; set; }

        [JsonPropertyName("Waste")]
        public double Waste { get; set; }

        [JsonPropertyName("Fluorinated gases")]
        public double FluorinatedGases { get; set; }

        [JsonPropertyName("Other")]
        public double Other { get; set; }
    }
}
