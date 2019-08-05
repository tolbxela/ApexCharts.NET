using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Grid
    {
        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("borderColor")]
        public string BorderColor { get; set; }

        [JsonProperty("strokeDashArray")]
        public int? StrokeDashArray { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("xaxis")]
        public GridXaxis Xaxis { get; set; }

        [JsonProperty("yaxis")]
        public GridYaxis Yaxis { get; set; }

        [JsonProperty("row")]
        public GridRow Row { get; set; }

        [JsonProperty("column")]
        public GridColumn Column { get; set; }

        [JsonProperty("padding")]
        public GridPadding Padding { get; set; }
    }
}