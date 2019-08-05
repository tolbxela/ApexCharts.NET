using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Tooltip
    {

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("enabledOnSeries")]
        public object EnabledOnSeries { get; set; }

        [JsonProperty("shared")]
        public bool? Shared { get; set; }

        [JsonProperty("followCursor")]
        public bool? FollowCursor { get; set; }

        [JsonProperty("intersect")]
        public bool? Intersect { get; set; }

        [JsonProperty("inverseOrder")]
        public bool? InverseOrder { get; set; }

        [JsonProperty("custom")]
        public object Custom { get; set; }

        [JsonProperty("fillSeriesColor")]
        public bool? FillSeriesColor { get; set; }

        [JsonProperty("theme")]
        public bool? Theme { get; set; }

        [JsonProperty("style")]
        public TooltipStyle Style { get; set; }

        [JsonProperty("onDatasetHover")]
        public OnDatasetHover OnDatasetHover { get; set; }

        [JsonProperty("x")]
        public TooltipX X { get; set; }

        [JsonProperty("y")]
        public TooltipY Y { get; set; }

        [JsonProperty("z")]
        public TooltipZ Z { get; set; }

        [JsonProperty("marker")]
        public TooltipMarker Marker { get; set; }

        [JsonProperty("items")]
        public TooltipItems Items { get; set; }

        [JsonProperty("fixed")]
        public TooltipFixed Fixed { get; set; }
    }
}