using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class DynamicAnimation
    {

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("speed")]
        public int? Speed { get; set; }
    }

}