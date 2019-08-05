using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Responsive
    {
        [JsonProperty("breakpoint")]
        public object Breakpoint { get; set; }

        [JsonProperty("options")]
        public object Options { get; set; }
    }
}       
