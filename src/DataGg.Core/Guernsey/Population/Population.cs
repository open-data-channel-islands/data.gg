using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Population
{
    class Population
    {
        [JsonPropertyName("Date Taken")]
        public string DateTaken { get; set; }

        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Sex")]
        public string Sex { get; set; }

        [JsonPropertyName("0-4")]
        public long The04 { get; set; }

        [JsonPropertyName("5-9")]
        public long The59 { get; set; }

        [JsonPropertyName("10-14")]
        public long The1014 { get; set; }

        [JsonPropertyName("15-19")]
        public long The1519 { get; set; }

        [JsonPropertyName("20-24")]
        public long The2024 { get; set; }

        [JsonPropertyName("25-29")]
        public long The2529 { get; set; }

        [JsonPropertyName("30-34")]
        public long The3034 { get; set; }

        [JsonPropertyName("35-39")]
        public long The3539 { get; set; }

        [JsonPropertyName("40-44")]
        public long The4044 { get; set; }

        [JsonPropertyName("45-49")]
        public long The4549 { get; set; }

        [JsonPropertyName("50-54")]
        public long The5054 { get; set; }

        [JsonPropertyName("55-59")]
        public long The5559 { get; set; }

        [JsonPropertyName("60-64")]
        public long The6064 { get; set; }

        [JsonPropertyName("65-69")]
        public long The6569 { get; set; }

        [JsonPropertyName("70-74")]
        public long The7074 { get; set; }

        [JsonPropertyName("75-79")]
        public long The7579 { get; set; }

        [JsonPropertyName("80-84")]
        public long The8084 { get; set; }

        [JsonPropertyName("85-89")]
        public long The8589 { get; set; }

        [JsonPropertyName("90-94")]
        public long The9094 { get; set; }

        [JsonPropertyName("95+")]
        public long The95 { get; set; }
    }
}
