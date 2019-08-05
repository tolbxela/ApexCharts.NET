using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class PieValue
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("formatter")]
        public object Formatter { get; set; }
    }
}