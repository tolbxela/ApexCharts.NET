using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{

    public class States
    {

        [JsonProperty("normal")]
        public StatesNormal Normal { get; set; }

        [JsonProperty("hover")]
        public StatesHover Hover { get; set; }

        [JsonProperty("active")]
        public StatesActive Active { get; set; }
    }
}