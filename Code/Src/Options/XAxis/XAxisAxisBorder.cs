using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class XAxisAxisBorder
{

    [JsonProperty("show")]
    public bool? Show { get; set; }

    [JsonProperty("color")]
    public string Color { get; set; }

    [JsonProperty("height")]
    public int? Height { get; set; }

    [JsonProperty("width")]
    public string Width { get; set; }

    [JsonProperty("offsetX")]
    public int? OffsetX { get; set; }

    [JsonProperty("offsetY")]
    public int? OffsetY { get; set; }
}
}
