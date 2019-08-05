using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class DatetimeFormatter
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }
    }
}
