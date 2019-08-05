using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class AnnotationsPadding
    {

        [JsonProperty("left")]
        public int? Left { get; set; }

        [JsonProperty("right")]
        public int? Right { get; set; }

        [JsonProperty("top")]
        public int? Top { get; set; }

        [JsonProperty("bottom")]
        public int? Bottom { get; set; }
    }
}
