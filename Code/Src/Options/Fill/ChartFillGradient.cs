using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class ChartFillGradient
    {
        [JsonProperty("shade")]
        public string Shade { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GradientType? Type { get; set; } = null;

        [JsonProperty("shadeIntensity")]
        public double? ShadeIntensity { get; set; }

        [JsonProperty("gradientToColors")]
        public object GradientToColors { get; set; }

        [JsonProperty("inverseColors")]
        public bool? InverseColors { get; set; }

        [JsonProperty("opacityFrom")]
        public double? OpacityFrom { get; set; }

        [JsonProperty("opacityTo")]
        public double? OpacityTo { get; set; }

        [JsonProperty("stops")]
        public IList<int> Stops { get; set; }

        [JsonProperty("colorStops")]
        public IList<object> ColorStops { get; set; }
    }
}