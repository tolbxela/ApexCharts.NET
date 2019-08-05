using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class YAxis
    {
        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("showAlways")]
        public bool? ShowAlways { get; set; }

        [JsonProperty("seriesName")]
        public object SeriesName { get; set; }

        [JsonProperty("opposite")]
        public bool? Opposite { get; set; }

        [JsonProperty("reversed")]
        public bool? Reversed { get; set; }

        [JsonProperty("logarithmic")]
        public bool? Logarithmic { get; set; }

        [JsonProperty("tickAmount")]
        public int? TickAmount { get; set; }

        [JsonProperty("min")]
        public int? Min { get; set; }

        [JsonProperty("max")]
        public int? Max { get; set; }

        [JsonProperty("forceNiceScale")]
        public bool? ForceNiceScale { get; set; }

        [JsonProperty("floating")]
        public bool? Floating { get; set; }

        [JsonProperty("decimalsInFloat")]
        public object DecimalsInFloat { get; set; }

        [JsonProperty("labels")]
        public YAxisLabels Labels { get; set; }

        [JsonProperty("axisBorder")]
        public YAxisAxisBorder AxisBorder { get; set; }

        [JsonProperty("axisTicks")]
        public YAxisAxisTicks AxisTicks { get; set; }

        [JsonProperty("title")]
        public YAxisTitle Title { get; set; }

        [JsonProperty("crosshairs")]
        public YAxisCrosshairs Crosshairs { get; set; }

        [JsonProperty("tooltip")]
        public YAxisTooltip Tooltip { get; set; }
    }
}