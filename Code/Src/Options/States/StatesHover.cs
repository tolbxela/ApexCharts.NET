using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class StatesHover
    {
        [JsonProperty("filter")]
        public StatesFilter Filter { get; set; }
    }
}
