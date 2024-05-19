using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Education
{
    public class StudentsInUk
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Other higher education")]
        public long OtherHigherEducation { get; set; }

        [JsonPropertyName("Undergraduate")]
        public long? Undergraduate { get; set; }

        [JsonPropertyName("Postgraduate")]
        public long? Postgraduate { get; set; }
        
        [JsonPropertyName("Total")]
        public long? Total { get; set; }
    }
}
