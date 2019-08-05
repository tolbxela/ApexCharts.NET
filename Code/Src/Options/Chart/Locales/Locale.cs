using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Locale
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public LocaleOptions Options { get; set; }
    }
}