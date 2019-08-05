using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class PieDataLabels
    {

        [JsonProperty("offset")]
        public int? Offset { get; set; }

        [JsonProperty("minAngleToShowLabel")]
        public int? MinAngleToShowLabel { get; set; }
    }
}