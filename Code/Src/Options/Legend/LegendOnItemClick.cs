using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class LegendOnItemClick
    {

        [JsonProperty("toggleDataSeries")]
        public bool? ToggleDataSeries { get; set; }
    }
}