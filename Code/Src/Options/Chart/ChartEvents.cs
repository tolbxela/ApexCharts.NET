using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ChartEvents
    {    
        [JsonProperty("click")]
        public object Click { get; set; }

        [JsonProperty("beforeMount")]
        public object BeforeMount { get; set; }

        [JsonProperty("mounted")]
        public object Mounted { get; set; }

        [JsonProperty("updated")]
        public object Updated { get; set; }

        [JsonProperty("legendClick")]
        public object LegendClick { get; set; }

        [JsonProperty("selection")]
        public object Selection { get; set; }

        [JsonProperty("dataPointSelection")]
        public object DataPointSelection { get; set; }

        [JsonProperty("dataPointMouseEnter")]
        public object DataPointMouseEnter { get; set; }

        [JsonProperty("dataPointMouseLeave")]
        public object DataPointMouseLeave { get; set; }

        [JsonProperty("beforeZoom")]
        public object BeforeZoom { get; set; }

        [JsonProperty("zoomed")]
        public object Zoomed { get; set; }

        [JsonProperty("scrolled")]
        public object Scrolled { get; set; }
    }

}