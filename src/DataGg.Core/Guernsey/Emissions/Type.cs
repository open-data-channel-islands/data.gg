using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Emissions
{
    public class Type
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Total emissions")]
        public double TotalEmissions { get; set; }

        [JsonPropertyName("CO2 Carbon dioxide total")]
        public double Co2CarbonDioxideTotal { get; set; }

        [JsonPropertyName("CH4 total Methane")]
        public double Ch4TotalMethane { get; set; }

        [JsonPropertyName("N2O total Nitrous oxide")]
        public double N2OTotalNitrousOxide { get; set; }

        [JsonPropertyName("Fluorinated gases total")]
        public double FluorinatedGasesTotal { get; set; }
    }
}
