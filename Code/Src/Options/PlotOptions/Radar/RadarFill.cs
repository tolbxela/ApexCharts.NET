using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class RadarFill
    {

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }
    }
}