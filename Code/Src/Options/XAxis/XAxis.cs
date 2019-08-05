using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class XAxis
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("categories")]
        public IList<object> Categories { get; set; }

        [JsonProperty("labels")]
        public XAxisLabels Labels { get; set; }

        [JsonProperty("axisBorder")]
        public XAxisAxisBorder AxisBorder { get; set; }

        [JsonProperty("axisTicks")]
        public XAxisAxisTicks AxisTicks { get; set; }

        [JsonProperty("tickAmount")]
        public object TickAmount { get; set; }

        [JsonProperty("tickPlacement")]
        public string TickPlacement { get; set; }

        [JsonProperty("min")]
        public object Min { get; set; }

        [JsonProperty("max")]
        public object Max { get; set; }

        [JsonProperty("range")]
        public object Range { get; set; }

        [JsonProperty("floating")]
        public bool? Floating { get; set; }

        [JsonProperty("position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public XAxisPosition? Position { get; set; }

        [JsonProperty("title")]
        public XAxisTitle Title { get; set; }

        [JsonProperty("crosshairs")]
        public XAxisCrosshairs Crosshairs { get; set; }

        [JsonProperty("tooltip")]
        public XAxisTooltip Tooltip { get; set; }
    }
}
