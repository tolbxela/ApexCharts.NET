using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class XAxisFill
    {

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public XAxisFillType? Type { get; set; } = null;

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("gradient")]
        public XAxisGradient Gradient { get; set; }
    }
}