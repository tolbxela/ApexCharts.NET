using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class PlotOptions
    {
        [JsonProperty("bar")]
        public Bar Bar { get; set; }

        [JsonProperty("candlestick")]
        public Candlestick Candlestick { get; set; }

        [JsonProperty("heatmap")]
        public Heatmap Heatmap { get; set; }

        [JsonProperty("pie")]
        public Pie Pie { get; set; }

        [JsonProperty("radar")]
        public Radar Radar { get; set; }

        [JsonProperty("radialBar")]
        public RadialBar RadialBar { get; set; }
    }  
}       
