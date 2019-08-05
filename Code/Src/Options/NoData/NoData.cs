using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class NoData
    {
        [JsonProperty("text")]
        public object Text { get; set; }

        [JsonProperty("align")]
        public string Align { get; set; }

        [JsonProperty("verticalAlign")]
        public string VerticalAlign { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("style")]
        public NoDataStyle Style { get; set; }
    }
}