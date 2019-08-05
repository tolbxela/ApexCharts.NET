using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class XAxisAxisTicks
{

    [JsonProperty("show")]
    public bool? Show { get; set; }

    [JsonProperty("borderType")]
    public string BorderType { get; set; }

    [JsonProperty("color")]
    public string Color { get; set; }

    [JsonProperty("height")]
    public int? Height { get; set; }

    [JsonProperty("offsetX")]
    public int? OffsetX { get; set; }

    [JsonProperty("offsetY")]
    public int? OffsetY { get; set; }
}
}
