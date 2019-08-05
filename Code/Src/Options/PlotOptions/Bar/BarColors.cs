using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class BarColors
    {

        [JsonProperty("ranges")]
        public IList<BarRanx> Ranges { get; set; }

        [JsonProperty("backgroundBarColors")]
        public IList<object> BackgroundBarColors { get; set; }

        [JsonProperty("backgroundBarOpacity")]
        public int? BackgroundBarOpacity { get; set; }
    }

}       
