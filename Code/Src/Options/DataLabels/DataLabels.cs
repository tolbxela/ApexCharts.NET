using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{

    public class DataLabels
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("enabledOnSeries")]
        public object EnabledOnSeries { get; set; }

        [JsonProperty("formatter")]
        public object Formatter { get; set; }

        [JsonProperty("textAnchor")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TextAnchorPosition? TextAnchor { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("style")]
        public DataLabelsStyle Style { get; set; }

        [JsonProperty("dropShadow")]
        public DropShadow DropShadow { get; set; }
    }
}