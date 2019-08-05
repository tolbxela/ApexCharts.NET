using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ChartFillPattern
    {
        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("strokeWidth")]
        public int? StrokeWidth { get; set; }
    }
}