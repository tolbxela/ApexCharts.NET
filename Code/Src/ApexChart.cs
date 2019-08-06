using System;
using Newtonsoft.Json;

namespace Tolbxela.ApexCharts
{
    public class ApexChart
    {
        public string ChartID { get; set; } = "apexchart";
        public string ChartVarName { get; set; } = "apexchart";

        public string HtmlSelector { get; set; }
        public ChartOptions Options { get; set; }
        public bool FormatJson { get; set; } = false;

        public ApexChart(string ChartName, string htmlSelector, ChartOptions options, bool formatJson = false)
        {
            FormatJson = formatJson;

            if (!string.IsNullOrWhiteSpace(ChartName)) {
                ChartID = ChartName;
                if (options != null && options.Chart != null) {
                    options.Chart.Id = ChartID;
                }
            } else if (options != null && !string.IsNullOrWhiteSpace(options?.Chart?.Id) ) {
                ChartID = options.Chart.Id;

            }
            ChartVarName = ChartID.Replace(" ", "_");
            HtmlSelector = htmlSelector;
            Options = options;
        }

        public override string ToString()
        {
            var jsonChart = "";
            try
            {
                var jsonOptions = JsonConvert.SerializeObject(
                    Options, 
                    (FormatJson) ? Formatting.Indented : Formatting.None, 
                    new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                    }
                );

                jsonChart = $"var {ChartVarName} = new ApexCharts(document.querySelector(\"{HtmlSelector}\"), {jsonOptions});" + 
                    Environment.NewLine + 
                    $"{ChartVarName}.render();";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return jsonChart;
        }
    }
}