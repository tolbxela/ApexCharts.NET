using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class CandlestickColors
    {

        [JsonProperty("upward")]
        public string Upward { get; set; }

        [JsonProperty("downward")]
        public string Downward { get; set; }
    }
}       
