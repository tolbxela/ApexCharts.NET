using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class XAxisLabels
    {

        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("rotate")]
        public int? Rotate { get; set; }

        [JsonProperty("rotateAlways")]
        public bool? RotateAlways { get; set; }

        [JsonProperty("hideOverlappingLabels")]
        public bool? HideOverlappingLabels { get; set; }

        [JsonProperty("showDuplicates")]
        public bool? ShowDuplicates { get; set; }

        [JsonProperty("trim")]
        public bool? Trim { get; set; }

        [JsonProperty("minHeight")]
        public object MinHeight { get; set; }

        [JsonProperty("maxHeight")]
        public int? MaxHeight { get; set; }

        [JsonProperty("style")]
        public XAxisStyle Style { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("format")]
        public object Format { get; set; }

        [JsonProperty("formatter")]
        public object Formatter { get; set; }

        [JsonProperty("datetimeFormatter")]
        public DatetimeFormatter DatetimeFormatter { get; set; }
    }
}
