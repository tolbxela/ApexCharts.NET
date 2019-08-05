using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ChartOptions
    {
        [JsonProperty("chart")]
        public Chart Chart { get; set; } = new Chart();

        [JsonProperty("annotations")]
        public Annotations Annotations { get; set; }

        [JsonProperty("dataLabels")]
        public DataLabels DataLabels { get; set; }

        [JsonProperty("colors")]
        public IList<object> Colors { get; set; }

        [JsonProperty("grid")]
        public Grid Grid { get; set; }

        [JsonProperty("fill")]
        public ChartFill Fill { get; set; }

        /// <summary>
        /// In Axis Charts (line / column), labels can be set instead of setting xaxis categories option. While, in pie/donut charts, each label corresponds to value in series array.
        /// </summary>
        [JsonProperty("labels")]
        public IList<object> Labels { get; set; }

        [JsonProperty("legend")]
        public Legend Legend { get; set; }

        [JsonProperty("markers")]
        public Markers Markers { get; set; }

        [JsonProperty("noData")]
        public NoData NoData { get; set; }

        [JsonProperty("series")]
        public IList<Serie> Series { get; set; }

        [JsonProperty("states")]
        public States States { get; set; }

        [JsonProperty("stroke")]
        public Stroke Stroke { get; set; }

        [JsonProperty("subtitle")]
        public Subtitle Subtitle { get; set; }

        [JsonProperty("theme")]
        public Theme Theme { get; set; }

        [JsonProperty("title")]
        public Title Title { get; set; }

        [JsonProperty("tooltip")]
        public Tooltip Tooltip { get; set; }

        [JsonProperty("xaxis")]
        public XAxis XAxis { get; set; }

        [JsonProperty("yaxis")]
        public YAxis YAxis { get; set; }

    }
}       
