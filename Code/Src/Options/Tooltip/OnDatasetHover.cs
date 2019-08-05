using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class OnDatasetHover
    {

        [JsonProperty("highlightDataSeries")]
        public bool? HighlightDataSeries { get; set; }
    }
}