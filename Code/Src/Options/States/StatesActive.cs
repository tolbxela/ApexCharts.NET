using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class StatesActive
    {
        [JsonProperty("allowMultipleDataPointsSelection")]
        public bool? AllowMultipleDataPointsSelection { get; set; }

        [JsonProperty("filter")]
        public StatesFilter Filter { get; set; }
    }
}