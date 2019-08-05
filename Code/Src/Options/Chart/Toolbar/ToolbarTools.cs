using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ToolbarTools
    {
        [JsonProperty("download")]
        public bool? Download { get; set; }

        [JsonProperty("selection")]
        public bool? Selection { get; set; }

        [JsonProperty("zoom")]
        public bool? Zoom { get; set; }

        [JsonProperty("zoomin")]
        public bool? Zoomin { get; set; }

        [JsonProperty("zoomout")]
        public bool? Zoomout { get; set; }

        [JsonProperty("pan")]
        public bool? Pan { get; set; }

        [JsonProperty("reset")]
        public string Reset { get; set; }

        [JsonProperty("customIcons")]
        public IList<object> CustomIcons { get; set; }
    }
}