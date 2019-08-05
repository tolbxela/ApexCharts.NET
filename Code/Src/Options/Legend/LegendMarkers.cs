using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class LegendMarkers
    {

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("strokeWidth")]
        public int? StrokeWidth { get; set; }

        [JsonProperty("strokeColor")]
        public string StrokeColor { get; set; }

        [JsonProperty("radius")]
        public int? Radius { get; set; }

        [JsonProperty("customHTML")]
        public object CustomHTML { get; set; }

        [JsonProperty("onClick")]
        public object OnClick { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }
    }
}