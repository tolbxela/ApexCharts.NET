using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class GridPadding
    {

        [JsonProperty("top")]
        public int? Top { get; set; }

        [JsonProperty("right")]
        public int? Right { get; set; }

        [JsonProperty("bottom")]
        public int? Bottom { get; set; }

        [JsonProperty("left")]
        public int? Left { get; set; }
    }
}