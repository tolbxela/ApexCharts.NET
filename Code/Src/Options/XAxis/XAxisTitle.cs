using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class XAxisTitle
    {

        [JsonProperty("text")]
        public object Text { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("style")]
        public XAxisStyle Style { get; set; }
    }
}