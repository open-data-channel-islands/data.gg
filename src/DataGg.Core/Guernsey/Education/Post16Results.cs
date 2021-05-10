using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace DataGg.Core.Guernsey.Education
{
    class Post16Results
    {
        [JsonPropertyName("Year")]
        public string Year { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Grade")]
        public string Grade { get; set; }

        [JsonPropertyName("Percent")]
        public double Percent { get; set; }
    }
}
