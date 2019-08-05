using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class AnnotationsYaxis
    {

        [JsonProperty("y")]
        public int? Y { get; set; }

        [JsonProperty("y2")]
        public object Y2 { get; set; }

        [JsonProperty("strokeDashArray")]
        public int? StrokeDashArray { get; set; }

        [JsonProperty("borderColor")]
        public string BorderColor { get; set; }

        [JsonProperty("fillColor")]
        public string FillColor { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("yAxisIndex")]
        public int? YAxisIndex { get; set; }

        [JsonProperty("label")]
        public AnnotationsLabel Label { get; set; }
    }
}
