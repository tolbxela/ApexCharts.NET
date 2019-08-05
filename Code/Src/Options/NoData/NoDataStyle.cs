using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class NoDataStyle
    {

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("fontFamily")]
        public object FontFamily { get; set; }
    }
}