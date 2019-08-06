using System.ComponentModel;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Sparkline
    {

        [JsonProperty("enabled")]
        [DefaultValue(false)]
        public bool? Enabled { get; set; } = false;
    }


}