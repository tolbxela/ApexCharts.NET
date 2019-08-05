using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class RadialBarDataLabels
{

    [JsonProperty("show")]
    public bool? Show { get; set; }

    [JsonProperty("name")]
    public RadialBarName Name { get; set; }

    [JsonProperty("value")]
    public RadialBarValue Value { get; set; }

    [JsonProperty("total")]
    public RadialBarTotal Total { get; set; }
}
}