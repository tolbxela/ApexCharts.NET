using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Heatmap
    {

        [JsonProperty("radius")]
        public int? Radius { get; set; }

        [JsonProperty("enableShades")]
        public bool? EnableShades { get; set; }

        [JsonProperty("shadeIntensity")]
        public double? ShadeIntensity { get; set; }

        [JsonProperty("reverseNegativeShade")]
        public bool? ReverseNegativeShade { get; set; }

        [JsonProperty("distributed")]
        public bool? Distributed { get; set; }

        [JsonProperty("colorScale")]
        public HeatmapColorScale ColorScale { get; set; }
    }
}