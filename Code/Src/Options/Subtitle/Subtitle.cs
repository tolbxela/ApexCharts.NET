using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{

    public class Subtitle
    {

        [JsonProperty("text")]
        public object Text { get; set; }

        [JsonProperty("align")]
        public string Align { get; set; }

        [JsonProperty("margin")]
        public int? Margin { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("floating")]
        public bool? Floating { get; set; }

        [JsonProperty("style")]
        public SubtitleStyle Style { get; set; }
    }


}