using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class SelectionYaxis
    {
        /// <summary>
        /// Start value of y-axis. (if used in a multiple y-axes chart, this considers the 1st y-axis).
        /// </summary>
        [JsonProperty("min")]
        public object Min { get; set; }

        /// <summary>
        /// End value of y-axis (if used in a multiple y-axes chart, this considers the 1st y-axis).
        /// </summary>
        [JsonProperty("max")]
        public object Max { get; set; }
    }
}