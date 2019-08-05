using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class StatesFilter
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }
    }
}
