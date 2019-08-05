using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class DropShadow
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("top")]
        public int? Top { get; set; }

        [JsonProperty("left")]
        public int? Left { get; set; }

        [JsonProperty("blur")]
        public int? Blur { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }
    }
}