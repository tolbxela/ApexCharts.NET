using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class LocaleOptions
    {
        [JsonProperty("months")]
        public IList<string> Months { get; set; }

        [JsonProperty("shortMonths")]
        public IList<string> ShortMonths { get; set; }

        [JsonProperty("days")]
        public IList<string> Days { get; set; }

        [JsonProperty("shortDays")]
        public IList<string> ShortDays { get; set; }

        [JsonProperty("toolbar")]
        public LocaleToolbar Toolbar { get; set; }
    }
}