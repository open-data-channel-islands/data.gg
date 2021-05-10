using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Sailings
{
    public class CondorPunctuality
    {
        [JsonPropertyName("route")]
        public string Route { get; set; }

        [JsonPropertyName("year")]
        public long Year { get; set; }

        [JsonPropertyName("quarter")]
        public long Quarter { get; set; }

        [JsonPropertyName("ontimepc")]
        public long Ontimepc { get; set; }

        [JsonPropertyName("upto15minspc")]
        public long Upto15Minspc { get; set; }

        [JsonPropertyName("upto30minspc")]
        public long Upto30Minspc { get; set; }

        [JsonPropertyName("upto60minspc")]
        public long Upto60Minspc { get; set; }

        [JsonPropertyName("over60minspc")]
        public long Over60Minspc { get; set; }

        [JsonPropertyName("scheduled")]
        public long Scheduled { get; set; }

        [JsonPropertyName("originalschedule")]
        public long Originalschedule { get; set; }

        [JsonPropertyName("originalschedulepc")]
        public double Originalschedulepc { get; set; }

        [JsonPropertyName("rescheduled")]
        public long Rescheduled { get; set; }

        [JsonPropertyName("rescheduledpc")]
        public double Rescheduledpc { get; set; }

        [JsonPropertyName("sailings")]
        public long Sailings { get; set; }

        [JsonPropertyName("sailingspc")]
        public double Sailingspc { get; set; }

        [JsonPropertyName("cancelled")]
        public long Cancelled { get; set; }

        [JsonPropertyName("cancelledpc")]
        public double Cancelledpc { get; set; }
    }
}
