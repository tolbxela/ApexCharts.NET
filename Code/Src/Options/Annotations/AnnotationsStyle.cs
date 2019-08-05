using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class AnnotationsStyle
    {
        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("cssClass")]
        public string CssClass { get; set; }

        [JsonProperty("padding")]
        public AnnotationsPadding Padding { get; set; }
    }
}
