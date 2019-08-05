using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class TooltipFixed
    {

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }
    }
}