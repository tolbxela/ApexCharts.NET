using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Legend
    {
        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("showForSingleSeries")]
        public bool? ShowForSingleSeries { get; set; }

        [JsonProperty("showForNullSeries")]
        public bool? ShowForNullSeries { get; set; }

        [JsonProperty("showForZeroSeries")]
        public bool? ShowForZeroSeries { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("horizontalAlign")]
        public string HorizontalAlign { get; set; }

        [JsonProperty("floating")]
        public bool? Floating { get; set; }

        [JsonProperty("fontSize")]
        public string FontSize { get; set; }

        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }

        [JsonProperty("width")]
        public object Width { get; set; }

        [JsonProperty("height")]
        public object Height { get; set; }

        [JsonProperty("formatter")]
        public object Formatter { get; set; }

        [JsonProperty("offsetX")]
        public int? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public int? OffsetY { get; set; }

        [JsonProperty("labels")]
        public LegendLabels Labels { get; set; }

        [JsonProperty("markers")]
        public LegendMarkers Markers { get; set; }

        [JsonProperty("itemMargin")]
        public LegendItemMargin ItemMargin { get; set; }

        [JsonProperty("onItemClick")]
        public LegendOnItemClick OnItemClick { get; set; }

        [JsonProperty("onItemHover")]
        public LegendOnItemHover OnItemHover { get; set; }
    }
}