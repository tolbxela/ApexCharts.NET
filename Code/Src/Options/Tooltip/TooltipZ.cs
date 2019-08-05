using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class TooltipZ
    {

        [JsonProperty("formatter")]
        public object Formatter { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}