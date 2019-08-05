using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class SelectionXaxis
    {
        /// <summary>
        /// Start value of x-axis. For a time-series chart, a timestamp should be provided
        /// </summary>
        [JsonProperty("min")]
        public object Min { get; set; }

        /// <summary>
        /// End value of x-axis. For a time-series chart, a timestamp should be provided.
        /// </summary>
        [JsonProperty("max")]
        public object Max { get; set; }
    }
}