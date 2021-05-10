using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Herm
{
    public class HermTrident
    {
        [JsonPropertyName("Date")]
        public string Date { get; set; }

        [JsonPropertyName("Depart")]
        public string Depart { get; set; }

        [JsonPropertyName("Return")]
        public string Return { get; set; }
    }

}
