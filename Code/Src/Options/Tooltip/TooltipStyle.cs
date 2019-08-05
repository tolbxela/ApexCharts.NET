using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class TooltipStyle
    {

        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("fontFamily")]
        public object FontFamily { get; set; }
    }
}