using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class BarRanx
    {

        [JsonProperty("from")]
        public int? From { get; set; }

        [JsonProperty("to")]
        public int? To { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }
    }

}       
