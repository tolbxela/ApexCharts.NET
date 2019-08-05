using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ZoomedAreaStroke
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }
}
