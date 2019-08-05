using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class ChartFill
    {
        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }

        [JsonProperty("opacity")]
        public double? Opacity { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FillType? Type { get; set; } = null;

        [JsonProperty("gradient")]
        public ChartFillGradient Gradient { get; set; }

        [JsonProperty("image")]
        public ChartFillImage Image { get; set; }

        [JsonProperty("pattern")]
        public ChartFillPattern Pattern { get; set; }
    }
}