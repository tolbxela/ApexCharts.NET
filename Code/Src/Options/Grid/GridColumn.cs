using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class GridColumn
    {

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }
    }
}