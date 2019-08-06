using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ToolbarTools
    {
        [JsonProperty("download")]
        [DefaultValue(true)]
        public bool? Download { get; set; }

        [JsonProperty("selection")]
        [DefaultValue(true)]
        public bool? Selection { get; set; }

        [JsonProperty("zoom")]
        [DefaultValue(true)]
        public bool? Zoom { get; set; }

        [JsonProperty("zoomin")]
        [DefaultValue(true)]
        public bool? Zoomin { get; set; }

        [JsonProperty("zoomout")]
        [DefaultValue(true)]
        public bool? Zoomout { get; set; }

        [JsonProperty("pan")]
        [DefaultValue(true)]
        public bool? Pan { get; set; }

        [JsonProperty("reset")]
        [DefaultValue(true)]
        public object Reset { get; set; }

        [JsonProperty("customIcons")]
        public IList<object> CustomIcons { get; set; }
    }
}