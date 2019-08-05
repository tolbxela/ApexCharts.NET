using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class LocaleToolbar
    {
        [JsonProperty("exportToSVG")]
        public string ExportToSVG { get; set; }

        [JsonProperty("exportToPNG")]
        public string ExportToPNG { get; set; }

        [JsonProperty("menu")]
        public string Menu { get; set; }

        [JsonProperty("selection")]
        public string Selection { get; set; }

        [JsonProperty("selectionZoom")]
        public string SelectionZoom { get; set; }

        [JsonProperty("zoomIn")]
        public string ZoomIn { get; set; }

        [JsonProperty("zoomOut")]
        public string ZoomOut { get; set; }

        [JsonProperty("pan")]
        public string Pan { get; set; }

        [JsonProperty("reset")]
        public string Reset { get; set; }
    }
}