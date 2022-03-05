using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Energy
{
    public class OilImports
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Transport Petrol")]
        public double TransportPetrol { get; set; }
        
        
        [JsonPropertyName("Transport Diesel")]
        public double TransportDiesel{ get; set; }
        
        
        [JsonPropertyName("Transport Other")]
        public double TransportOther { get; set; }

        [JsonPropertyName("Heating Electricity")]
        public double HeatingElectricity { get; set; }
    }
}
