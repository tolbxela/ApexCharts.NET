using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class TitleStyle
    {

        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}