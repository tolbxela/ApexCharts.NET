using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class TooltipX
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("formatter")]
        public object Formatter { get; set; }
    }
}