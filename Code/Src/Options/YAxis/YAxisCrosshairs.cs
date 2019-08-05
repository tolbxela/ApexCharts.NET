using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class YAxisCrosshairs
{

    [JsonProperty("show")]
    public bool? Show { get; set; }

    [JsonProperty("position")]
    public string Position { get; set; }

    [JsonProperty("stroke")]
    public YAxisStroke Stroke { get; set; }
}
}