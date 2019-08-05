using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class GridYaxis
    {

        [JsonProperty("lines")]
        public GridLines Lines { get; set; }
    }
}