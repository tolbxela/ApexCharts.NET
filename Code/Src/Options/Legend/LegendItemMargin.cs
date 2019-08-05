using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class LegendItemMargin
    {

        [JsonProperty("horizontal")]
        public int? Horizontal { get; set; }

        [JsonProperty("vertical")]
        public int? Vertical { get; set; }
    }
}