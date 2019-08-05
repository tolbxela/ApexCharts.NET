using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Candlestick
    {

        [JsonProperty("colors")]
        public CandlestickColors Colors { get; set; }

        [JsonProperty("wick")]
        public CandlestickWick Wick { get; set; }
    }
}       
