using Newtonsoft.Json;

public class AnnotationsMarker
{

    [JsonProperty("size")]
    public int? Size { get; set; }

    [JsonProperty("fillColor")]
    public string FillColor { get; set; }

    [JsonProperty("strokeColor")]
    public string StrokeColor { get; set; }

    [JsonProperty("strokeWidth")]
    public int? StrokeWidth { get; set; }

    [JsonProperty("shape")]
    public string Shape { get; set; }

    [JsonProperty("radius")]
    public int? Radius { get; set; }

    [JsonProperty("OffsetX")]
    public int? OffsetX { get; set; }

    [JsonProperty("OffsetY")]
    public int? OffsetY { get; set; }

    [JsonProperty("cssClass")]
    public string CssClass { get; set; }
}
