using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class LegendLabels
    {

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }

        [JsonProperty("useSeriesColors")]
        public bool? UseSeriesColors { get; set; }
    }
}