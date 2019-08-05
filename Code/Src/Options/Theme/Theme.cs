using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Theme
    {

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("palette")]
        public string Palette { get; set; }

        [JsonProperty("monochrome")]
        public ThemeMonochrome Monochrome { get; set; }
    }
}