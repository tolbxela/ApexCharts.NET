using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Radar
    {
        [JsonProperty("size")]
        public object Size { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("polygons")]
        public RadarPolygons Polygons { get; set; }
    }
}