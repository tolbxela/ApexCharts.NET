using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class SelectionFill
    {

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }
    }
}