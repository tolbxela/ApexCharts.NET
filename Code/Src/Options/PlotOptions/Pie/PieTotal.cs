using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class PieTotal
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("formatter")]
        public object Formatter { get; set; }
    }
}