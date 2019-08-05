using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class Animations
    {

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("easing")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EasingType? Easing { get; set; } = null;

        [JsonProperty("speed")]
        public int? Speed { get; set; }

        [JsonProperty("animateGradually")]
        public AnimateGradually AnimateGradually { get; set; }

        [JsonProperty("dynamicAnimation")]
        public DynamicAnimation DynamicAnimation { get; set; }
    }

}