using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class XAxisStyle
    {

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }

        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }

        [JsonProperty("cssClass")]
        public string CssClass { get; set; }
    }
}
