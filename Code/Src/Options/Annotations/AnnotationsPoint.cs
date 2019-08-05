using Newtonsoft.Json;
namespace Tolbxela.ApexCharts
{
    public class AnnotationsPoint
    {

        [JsonProperty("x")]
        public int? X { get; set; }

        [JsonProperty("y")]
        public object Y { get; set; }

        [JsonProperty("yAxisIndex")]
        public int? YAxisIndex { get; set; }

        [JsonProperty("seriesIndex")]
        public int? SeriesIndex { get; set; }

        [JsonProperty("marker")]
        public AnnotationsMarker Marker { get; set; }

        [JsonProperty("label")]
        public AnnotationsLabel Label { get; set; }
    }
}