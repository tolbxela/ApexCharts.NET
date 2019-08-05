using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class YAxisStyle
    {

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }

        [JsonProperty("cssClass")]
        public string CssClass { get; set; }
    }
}
