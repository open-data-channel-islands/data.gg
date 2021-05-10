using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Population
{
    public class Changes
    {
        [JsonPropertyName("Date")]
        public string Date { get; set; }

        [JsonPropertyName("Births")]
        public long Births { get; set; }

        [JsonPropertyName("Deaths")]
        public long Deaths { get; set; }

        [JsonPropertyName("Natural increase")]
        public long NaturalIncrease { get; set; }

        [JsonPropertyName("Immigration")]
        public long Immigration { get; set; }

        [JsonPropertyName("Emigration")]
        public long Emigration { get; set; }

        [JsonPropertyName("Net Migration")]
        public long NetMigration { get; set; }
    }
}
