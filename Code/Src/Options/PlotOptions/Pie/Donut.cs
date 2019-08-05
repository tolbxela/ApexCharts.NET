using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Donut
    {

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("labels")]
        public PieLabels Labels { get; set; }
    }
}