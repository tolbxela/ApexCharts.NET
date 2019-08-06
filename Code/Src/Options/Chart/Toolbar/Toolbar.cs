using System.ComponentModel;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Toolbar
    {

        [JsonProperty("show")]
        [DefaultValue(true)]
        public bool? Show { get; set; } = true;

        [JsonProperty("tools")]
        public ToolbarTools Tools { get; set; }

        [JsonProperty("autoSelected")]
        public string AutoSelected { get; set; }
    }
}