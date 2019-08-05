using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class Selection
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SelectionType? Type { get; set; } = SelectionType.x;

        [JsonProperty("fill")]
        public SelectionFill Fill { get; set; }

        [JsonProperty("stroke")]
        public SelectionStroke Stroke { get; set; }

        [JsonProperty("xaxis")]
        public SelectionXaxis Xaxis { get; set; }

        [JsonProperty("yaxis")]
        public SelectionYaxis Yaxis { get; set; }
    }
}