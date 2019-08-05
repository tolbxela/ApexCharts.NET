using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class RadialBar
    {

        [JsonProperty("size")]
        public object Size { get; set; }

        [JsonProperty("inverseOrder")]
        public bool? InverseOrder { get; set; }

        [JsonProperty("startAngle")]
        public int? StartAngle { get; set; }

        [JsonProperty("endAngle")]
        public int? EndAngle { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("hollow")]
        public RadialBarHollow Hollow { get; set; }

        [JsonProperty("track")]
        public RadialBarTrack Track { get; set; }

        [JsonProperty("dataLabels")]
        public RadialBarDataLabels DataLabels { get; set; }
    }
}