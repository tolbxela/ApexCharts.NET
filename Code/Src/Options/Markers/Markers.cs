using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Markers
    {

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }

        [JsonProperty("strokeColors")]
        public string StrokeColors { get; set; }

        [JsonProperty("strokeWidth")]
        public int? StrokeWidth { get; set; }

        [JsonProperty("strokeOpacity")]
        public double? StrokeOpacity { get; set; }

        [JsonProperty("fillOpacity")]
        public int? FillOpacity { get; set; }

        [JsonProperty("discrete")]
        public IList<object> Discrete { get; set; }

        [JsonProperty("shape")]
        public string Shape { get; set; }

        [JsonProperty("radius")]
        public int? Radius { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("onClick")]
        public object OnClick { get; set; }

        [JsonProperty("onDblClick")]
        public object OnDblClick { get; set; }

        [JsonProperty("hover")]
        public MarkersHover Hover { get; set; }
    }
}