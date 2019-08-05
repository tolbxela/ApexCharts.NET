using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class YAxisLabels
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("align")]
        public string Align { get; set; }

        [JsonProperty("minWidth")]
        public int? MinWidth { get; set; }

        [JsonProperty("maxWidth")]
        public int? MaxWidth { get; set; }

        [JsonProperty("style")]
        public YAxisStyle Style { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("rotate")]
        public int? Rotate { get; set; }

        [JsonProperty("formatter")]
        public object Formatter { get; set; }
    }
}
