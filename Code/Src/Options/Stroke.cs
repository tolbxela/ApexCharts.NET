using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class Stroke
    {
        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("curve")]
        public string Curve { get; set; }

        [JsonProperty("lineCap")]
        public string LineCap { get; set; }

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("dashArray")]
        public int? DashArray { get; set; }
    }
}