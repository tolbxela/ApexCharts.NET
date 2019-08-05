using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ZoomedArea
    {
        [JsonProperty("fill")]
        public ZoomedAreaFill Fill { get; set; }

        [JsonProperty("stroke")]
        public ZoomedAreaStroke Stroke { get; set; }
    }

}
