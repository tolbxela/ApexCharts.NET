using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class HeatmapRanx
    {

        [JsonProperty("from")]
        public int? From { get; set; }

        [JsonProperty("to")]
        public int? To { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }
    }
}