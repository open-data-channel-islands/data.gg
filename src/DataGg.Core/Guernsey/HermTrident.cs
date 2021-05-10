using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey
{
    class HermTrident
    {
        [JsonPropertyName("Date")]
        public string Date { get; set; }

        [JsonPropertyName("Depart")]
        public string Depart { get; set; }

        [JsonPropertyName("Return")]
        public string Return { get; set; }
    }

}
