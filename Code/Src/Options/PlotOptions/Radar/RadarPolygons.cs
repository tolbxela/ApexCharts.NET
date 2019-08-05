using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class RadarPolygons
    {
        [JsonProperty("strokeColors")]
        public string StrokeColors { get; set; }

        [JsonProperty("connectorColors")]
        public string ConnectorColors { get; set; }

        [JsonProperty("fill")]
        public RadarFill Fill { get; set; }
    }
}