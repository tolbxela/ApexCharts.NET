using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class XAxisGradient
    {

        [JsonProperty("colorFrom")]
        public string ColorFrom { get; set; }

        [JsonProperty("colorTo")]
        public string ColorTo { get; set; }

        [JsonProperty("stops")]
        public IList<int> Stops { get; set; }

        [JsonProperty("opacityFrom")]
        public double? OpacityFrom { get; set; }

        [JsonProperty("opacityTo")]
        public double? OpacityTo { get; set; }
    }
}