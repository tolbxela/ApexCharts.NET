using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class LegendOnItemHover
    {

        [JsonProperty("highlightDataSeries")]
        public bool? HighlightDataSeries { get; set; }
    }
}