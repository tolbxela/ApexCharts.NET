using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class ChartZoom
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ZoomType? Type { get; set; } = ZoomType.x;

        [JsonProperty("autoScaleYaxis")]
        public bool? AutoScaleYaxis { get; set; }

        [JsonProperty("zoomedArea")]
        public ZoomedArea ZoomedArea { get; set; }
    }

}
