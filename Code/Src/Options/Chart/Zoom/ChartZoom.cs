using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class ChartZoom
    {
        [JsonProperty("enabled")]
        [DefaultValue(false)]
        public bool? Enabled { get; set; } = false;

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        [DefaultValue(ZoomType.x)]
        public ZoomType? Type { get; set; }

        [JsonProperty("autoScaleYaxis")]
        public bool? AutoScaleYaxis { get; set; }

        [JsonProperty("zoomedArea")]
        public ZoomedArea ZoomedArea { get; set; }
    }

}
