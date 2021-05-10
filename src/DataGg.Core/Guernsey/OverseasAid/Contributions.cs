using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.OverseasAid
{
    public class Contributions
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Africa Aid")]
        public long AfricaAid { get; set; }

        [JsonPropertyName("Africa Emergency Relief")]
        public long? AfricaEmergencyRelief { get; set; }

        [JsonPropertyName("Europe Aid")]
        public object EuropeAid { get; set; }

        [JsonPropertyName("Europe Emergency Relief")]
        public long? EuropeEmergencyRelief { get; set; }

        [JsonPropertyName("Indian Sub-Continent Aid")]
        public long IndianSubContinentAid { get; set; }

        [JsonPropertyName("Indian Sub-Continent Emergency Relief")]
        public long? IndianSubContinentEmergencyRelief { get; set; }

        [JsonPropertyName("Latin America and Caribbean Aid")]
        public long LatinAmericaAndCaribbeanAid { get; set; }

        [JsonPropertyName("Latin America and Caribbean Emergency Relief")]
        public long? LatinAmericaAndCaribbeanEmergencyRelief { get; set; }

        [JsonPropertyName("Other Asia and Pacific Aid")]
        public long OtherAsiaAndPacificAid { get; set; }

        [JsonPropertyName("Other Asia and Pacific Emergency Relief")]
        public long? OtherAsiaAndPacificEmergencyRelief { get; set; }

        [JsonPropertyName("Middle East Aid")]
        public long? MiddleEastAid { get; set; }

        [JsonPropertyName("Middle East Emergency Relief")]
        public long? MiddleEastEmergencyRelief { get; set; }
    }
}
