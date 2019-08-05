using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class GridXaxis
    {

        [JsonProperty("lines")]
        public GridLines Lines { get; set; }
    }
}