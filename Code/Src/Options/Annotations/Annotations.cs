using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class Annotations
    {

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("yaxis")]
        public IList<AnnotationsYaxis> Yaxis { get; set; }

        [JsonProperty("xaxis")]
        public IList<AnnotationsXaxis> Xaxis { get; set; }

        [JsonProperty("points")]
        public IList<AnnotationsPoint> Points { get; set; }
    }
}
