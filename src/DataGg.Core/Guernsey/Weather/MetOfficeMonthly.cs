using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Weather
{
    class MetOfficeMonthly
    {
        [JsonPropertyName("year")]
        public long Year { get; set; }

        [JsonPropertyName("month")]
        public string Month { get; set; }

        [JsonPropertyName("temperature")]
        public double Temperature { get; set; }

        [JsonPropertyName("temperaturedifferencefromaverage")]
        public double Temperaturedifferencefromaverage { get; set; }

        [JsonPropertyName("rainfall")]
        public double Rainfall { get; set; }

        [JsonPropertyName("rainfallpercentofaverage")]
        public double Rainfallpercentofaverage { get; set; }

        [JsonPropertyName("sunshine")]
        public double Sunshine { get; set; }

        [JsonPropertyName("sunshinepercentofaverage")]
        public double Sunshinepercentofaverage { get; set; }
    }
}
