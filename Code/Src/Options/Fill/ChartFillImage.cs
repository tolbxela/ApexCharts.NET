using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ChartFillImage
    {
        [JsonProperty("src")]
        public IList<object> Src { get; set; }

        [JsonProperty("width")]
        public object Width { get; set; }

        [JsonProperty("height")]
        public object Height { get; set; }
    }
}