using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Bar
    {

        [JsonProperty("horizontal")]
        public bool? Horizontal { get; set; }

        [JsonProperty("endingShape")]
        public string EndingShape { get; set; }

        [JsonProperty("columnWidth")]
        public string ColumnWidth { get; set; }

        [JsonProperty("barHeight")]
        public string BarHeight { get; set; }

        [JsonProperty("distributed")]
        public bool? Distributed { get; set; }

        [JsonProperty("colors")]
        public BarColors Colors { get; set; }

        [JsonProperty("dataLabels")]
        public BarDataLabels DataLabels { get; set; }
    }

}       
