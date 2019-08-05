using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class XAxisCrosshairs
    {
        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }

        [JsonProperty("stroke")]
        public XAxisStroke Stroke { get; set; }

        [JsonProperty("fill")]
        public XAxisFill Fill { get; set; }

        [JsonProperty("dropShadow")]
        public DropShadow DropShadow { get; set; }
    }
}