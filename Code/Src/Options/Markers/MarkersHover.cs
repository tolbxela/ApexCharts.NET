using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class MarkersHover
    {

        [JsonProperty("size")]
        public object Size { get; set; }

        [JsonProperty("sizeOffset")]
        public int? SizeOffset { get; set; }
    }
}