using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class HeatmapColorScale
    {

        [JsonProperty("ranges")]
        public IList<HeatmapRanx> Ranges { get; set; }

        [JsonProperty("inverse")]
        public bool? Inverse { get; set; }

        [JsonProperty("min")]
        public object Min { get; set; }

        [JsonProperty("max")]
        public object Max { get; set; }
    }
}