using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class YAxisTooltip
{

    [JsonProperty("enabled")]
    public bool? Enabled { get; set; }

    [JsonProperty("offsetX")]
    public int? OffsetX { get; set; }
}
}