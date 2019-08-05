using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class DataLabelsStyle
    {
        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }
    }
}