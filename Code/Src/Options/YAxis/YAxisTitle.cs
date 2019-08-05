using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class YAxisTitle
    {

        [JsonProperty("text")]
        public object Text { get; set; }

        [JsonProperty("rotate")]
        public int? Rotate { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("style")]
        public YAxisStyle Style { get; set; }
    }
}