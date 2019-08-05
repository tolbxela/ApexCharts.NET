using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Toolbar
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("tools")]
        public ToolbarTools Tools { get; set; }

        [JsonProperty("autoSelected")]
        public string AutoSelected { get; set; }
    }
}