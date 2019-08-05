using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class AnnotationsLabel
    {
        [JsonProperty("borderColor")]
        public string BorderColor { get; set; }

        [JsonProperty("borderWidth")]
        public int? BorderWidth { get; set; }

        [JsonProperty("text")]
        public object Text { get; set; }

        [JsonProperty("textAnchor")]
        public string TextAnchor { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("style")]
        public AnnotationsStyle Style { get; set; }
    }
}
