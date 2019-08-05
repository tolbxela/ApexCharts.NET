using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class AnimateGradually
    {

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("delay")]
        public int? Delay { get; set; }
    }

}