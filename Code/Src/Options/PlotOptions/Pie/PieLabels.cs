using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class PieLabels
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("name")]
        public PieName Name { get; set; }

        [JsonProperty("value")]
        public PieValue Value { get; set; }

        [JsonProperty("total")]
        public PieTotal Total { get; set; }
    }
}