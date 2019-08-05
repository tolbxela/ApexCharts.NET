using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ThemeMonochrome
    {

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("shadeTo")]
        public string ShadeTo { get; set; }

        [JsonProperty("shadeIntensity")]
        public double? ShadeIntensity { get; set; }
    }

}