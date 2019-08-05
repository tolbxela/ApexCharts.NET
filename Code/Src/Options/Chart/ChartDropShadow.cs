using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ChartDropShadow : DropShadow
    {
        [JsonProperty("enabledOnSeries")]
        public object EnabledOnSeries { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}