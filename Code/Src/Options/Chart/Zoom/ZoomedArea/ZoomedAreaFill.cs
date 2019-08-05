using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ZoomedAreaFill
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }
    }
}
