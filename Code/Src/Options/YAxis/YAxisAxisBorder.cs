using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class YAxisAxisBorder
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }
    }
}
