using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ChartBrush
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("target")]
        public object Target { get; set; }

        [JsonProperty("autoScaleYaxis")]
        public bool? AutoScaleYaxis { get; set; }
    }
}