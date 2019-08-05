using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class RadialBarHollow
    {

        [JsonProperty("margin")]
        public int? Margin { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("image")]
        public object Image { get; set; }

        [JsonProperty("imageWidth")]
        public int? ImageWidth { get; set; }

        [JsonProperty("imageHeight")]
        public int? ImageHeight { get; set; }

        [JsonProperty("imageOffsetX")]
        public int? ImageOffsetX { get; set; }

        [JsonProperty("imageOffsetY")]
        public int? ImageOffsetY { get; set; }

        [JsonProperty("imageClipped")]
        public bool? ImageClipped { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("dropShadow")]
        public DropShadow DropShadow { get; set; }
    }
}
