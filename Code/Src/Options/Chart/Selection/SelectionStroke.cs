using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class SelectionStroke
    {
        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("dashArray")]
        public int? DashArray { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }
    }
}