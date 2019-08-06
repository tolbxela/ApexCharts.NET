using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.ApexCharts
{
    public class Chart
    {
        /// <summary>
        /// Chart ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("height")]
        public object Height { get; set; }

        /// <summary>
        /// Width of the chart. 
        /// Accepts Number(400) OR String(‘400px’)
        /// </summary>
        [JsonProperty("width")]
        public object Width { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        /// <summary>
        /// Sets the font family for all the text elements of the chart. Defaults to 'Helvetica, Arial, sans-serif'
        /// </summary>
        [JsonProperty("fontFamily")]
        [DefaultValue("Helvetica, Arial, sans-serif")]
        public string FontFamily { get; set; }

        /// <summary>
        /// Sets the text color for the chart. Defaults to #373d3f
        /// </summary>
        [JsonProperty("foreColor")]
        [DefaultValue("373d3f")]
        public string ForeColor { get; set; }

        /// <summary>
        /// A small increment in height added to the parent of chart element.
        /// </summary>
        [JsonProperty("parentHeightOffset")]
        public string ParentHeightOffset { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("selection")]
        public Selection Selection { get; set; }

        /// <summary>
        /// Sparkline hides all the elements of the charts other than the primary paths. Helps to visualize data in small areas 
        /// </summary>
        [JsonProperty("sparkline")]
        public Sparkline Sparkline { get; set; }

        /// <summary>
        /// Enables stacked option for axis charts. 
        /// </summary>
        [JsonProperty("stacked")]
        public bool? Stacked { get; set; }

        /// <summary>
        /// When stacked, should the stacking be percentage based or normal stacking. 
        /// </summary>
        [JsonProperty("stackType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StackType? StackType { get; set; } = null;

        [JsonProperty("toolbar")]
        public Toolbar Toolbar { get; set; }

        /// <summary>
        /// Specify the chart type 
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        [DefaultValue(ChartType.line)]
        public ChartType? Type { get; set; }

        [JsonProperty("zoom")]
        public ChartZoom Zoom { get; set; }

        [JsonProperty("locales")]
        public IList<object> Locales { get; set; }

        [JsonProperty("defaultLocale")]
        public string DefaultLocale { get; set; }

    }
}