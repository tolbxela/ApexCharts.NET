using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Pie
    {

        [JsonProperty("size")]
        public object Size { get; set; }

        [JsonProperty("customScale")]
        public int? CustomScale { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("expandOnClick")]
        public bool? ExpandOnClick { get; set; }

        [JsonProperty("dataLabels")]
        public PieDataLabels DataLabels { get; set; }

        [JsonProperty("donut")]
        public Donut Donut { get; set; }
    }
}