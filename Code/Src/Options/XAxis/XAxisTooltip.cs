using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class XAxisTooltip
    {

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("formatter")]
        public object Formatter { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("style")]
        public XAxisStyle Style { get; set; }
    }
}