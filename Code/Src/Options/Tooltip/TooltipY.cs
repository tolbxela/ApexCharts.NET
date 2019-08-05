using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class TooltipY
    {

        [JsonProperty("formatter")]
        public object Formatter { get; set; }

        [JsonProperty("title")]
        public TooltipTitle Title { get; set; }
    }
}