using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class Title
    {

        [JsonProperty("text")]
        public object Text { get; set; }

        [JsonProperty("align")]
        //[JsonConverter(typeof(PlainJsonStringConverter))]
        [JsonConverter(typeof(StringEnumConverter))]
        public AlignType? Align { get; set; } = null;

        [JsonProperty("margin")]
        public int? Margin { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("floating")]
        public bool? Floating { get; set; }

        [JsonProperty("style")]
        public TitleStyle Style { get; set; }
    }
}