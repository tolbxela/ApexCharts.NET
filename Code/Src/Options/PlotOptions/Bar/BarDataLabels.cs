using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class BarDataLabels
    {

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("maxItems")]
        public int? MaxItems { get; set; }

        [JsonProperty("hideOverflowingLabels")]
        public bool? HideOverflowingLabels { get; set; }
    }

}       
