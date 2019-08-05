using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class YAxisStroke
    {

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("dashArray")]
        public int? DashArray { get; set; }
    }
}