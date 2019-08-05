using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class StatesNormal
    {
        [JsonProperty("filter")]
        public StatesFilter Filter { get; set; }
    }
}
