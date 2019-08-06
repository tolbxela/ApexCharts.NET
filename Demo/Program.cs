using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Tolbxela.ApexCharts;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var curDir = Directory.GetCurrentDirectory();
            Console.WriteLine($"Current Directory: {curDir}");
            try
            {
                var months = 12;

                var FileName = "democharts.js";

                var chart = new Chart()
                {
                    Height = 350,
                    Type = ChartType.area,
                    Zoom = new ChartZoom()
                    {
                        Enabled = true,
                        Type = ZoomType.x
                    }
                };

                Random r = new Random();

                var series = new List<Serie>()
                {
                    new Serie()
                    {
                        Name = "Data 1",
                        Data =  Enumerable.Range(0, months)
                              .Select(x => r.Next(1000))
                              .Select(y => (object)y)
                              .ToArray()
                    },
                                        new Serie()
                    {
                        Name = "Data 2",
                        Data =  Enumerable.Range(0, months)
                              .Select(x => r.Next(1000))
                              .Select(y => (object)y)
                              .ToArray()
                    }

                };

                var Year = DateTime.Now.Year.ToString();

                var xAxis = new XAxis()
                {
                    Type = "datetime",
                    Categories =
                        Enumerable.Range(0, months)
                              .Select(i => DateTime.Now.AddMonths(i - months))
                              .Select(date => date.ToString("yyyy-MM-01"))
                              .ToArray<object>()
                };


                var yAxis = new YAxis()
                {
                    Min = 0,
                    Max = 1000,
                    ForceNiceScale = true
                };

                var grid = new Grid()
                {

                    Yaxis = new GridYaxis()
                    {
                        Lines = new GridLines()
                        {
                            Show = true
                        }
                    },
                    Xaxis = new GridXaxis()
                    {
                        Lines = new GridLines()
                        {
                            Show = false
                        }
                    }
                };

                var annotations = new Annotations()
                {
                    Yaxis = new List<AnnotationsYaxis>(){
                        new AnnotationsYaxis() {
                            Y = 0,
                            BorderColor = "grey"
                        }
                    }
                };

                var options = new ChartOptions()
                {
                    Chart = chart,
                    Series = series,
                    DataLabels = new DataLabels()
                    {
                        Enabled = false,
                        Style = new DataLabelsStyle() {
                            FontSize = "8pt",
                            Colors = new string[] { "black", "black" }
                        }
                    },
                    Colors = new string[] { "#5bcaff", "#ff82d0" },
                    Markers = new Markers()
                    {
                        Size = 4,
                        Hover = new MarkersHover() {
                            Size = 6
                        }                        
                    },
                    Title = new Title()
                    {
                        Text = "Chart Title",
                        Align = AlignType.left
                    },
                    Grid = grid,
                    XAxis = xAxis,
                    YAxis = yAxis,
                    Annotations = annotations,
                    Stroke = new Stroke()
                    {
                        Width = 2,
                        Curve = StrokeCurve.straight
                    },
                    Fill = new ChartFill() {
                        Type = FillType.gradient,
                        Gradient = new ChartFillGradient() {

                        ShadeIntensity = 1,
                        OpacityFrom = 0.7,
                        OpacityTo = 0.9,
                        Stops = new List<int>() {
                            0, 100
                        }
                      }
                    }
                };

                var apexchart = new ApexChart("apexchart", "#ApexChart", options, formatJson: true);

                Console.WriteLine($"Saving Chart to file '{FileName}'");
                File.WriteAllText(FileName, apexchart.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Starting default browser with 'index.html'");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = "index.html";
            proc.Start();

            //Console.WriteLine("Press any key...");
            //Console.ReadKey();

        }
    }
}
