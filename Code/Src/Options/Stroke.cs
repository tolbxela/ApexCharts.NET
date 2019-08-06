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
        [JsonConverter(typeof(StringEnumConverter))]
        [DefaultValue(StrokeCurve.straight)]
        public StrokeCurve? Curve { get; set; }

        [JsonProperty("lineCap")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LineCap? LineCap { get; set; }

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("dashArray")]
        public int? DashArray { get; set; }
    }
}