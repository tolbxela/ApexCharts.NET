using System;
using Newtonsoft.Json;
using Tolbxela.ApexCharts;
using Xunit;

namespace Test
{
    public class ApexChartTests
    {
        const string ChartName = "Chart";
        const string Selector = "#Selector";

        public ApexChartTests()
        {
        }

        [Fact]
        public void ApexChartTest_NotNull()
        {
            var chart = new ApexChart(ChartName, Selector, null, formatJson: false);
            Assert.NotNull(chart);
        }

        [Fact]
        public void ApexChartTest_Json()
        {
            var chart = new ApexChart(ChartName, Selector, null, formatJson: false);
            var json = chart.ToString();
            Assert.False(string.IsNullOrWhiteSpace(json));
        }

        [Fact]
        public void ApexChartTest_NullOptions()
        {
            var chart = new ApexChart(ChartName, Selector, null, formatJson: false);
            var chartJson = chart.ToString();
            var options = "null";
            var chartSample = $"var {ChartName} = new ApexCharts(document.querySelector(\"{Selector}\"), {options});" + Environment.NewLine +
            $"{ChartName}.render();";

            Assert.Equal(chartSample, chartJson);
        }

        [Fact]
        public void ApexChartTest_EmptyOptions()
        {
            var options = new ChartOptions();

            var jsonOptions = JsonConvert.SerializeObject(
                    options,
                    Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }
                );

            var jsonOptionsSample = "{\"chart\":{}}";

            Assert.Equal(jsonOptionsSample, jsonOptions);
        }

        [Fact]
        public void ApexChartTest_EmptyChart()
        {
            var options = new ChartOptions();
           
            var chart = new ApexChart(ChartName, Selector, options, formatJson: false);
            var chartJson = chart.ToString();
            var jsonOptionsSample = "{\"chart\":{\"id\":\"" + ChartName + "\"}}";
            var chartSample = $"var {ChartName} = new ApexCharts(document.querySelector(\"{Selector}\"), {jsonOptionsSample});" + Environment.NewLine +
            $"{ChartName}.render();";

            Assert.Equal(chartSample, chartJson);
        }
    }
}
