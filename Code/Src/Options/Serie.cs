using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Serie
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data")]
        public IList<object> Data { get; set; }
    }
}