using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class RadialBarTrack
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("startAngle")]
        public object StartAngle { get; set; }

        [JsonProperty("endAngle")]
        public object EndAngle { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("strokeWidth")]
        public string StrokeWidth { get; set; }

        [JsonProperty("opacity")]
        public int? Opacity { get; set; }

        [JsonProperty("margin")]
        public int? Margin { get; set; }

        [JsonProperty("dropShadow")]
        public DropShadow DropShadow { get; set; }
    }
}