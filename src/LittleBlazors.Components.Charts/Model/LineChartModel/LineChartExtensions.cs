using System.Collections.Generic;

namespace LittleBlazors.Components.Charts.Model.LineChartModel
{
    public static class LineChartExtensions
    {
        public static LinearChartData AddLine(this LinearChartData chartData, string lineName, LineData lineData)
        {
            chartData.Lines.Add(lineName, lineData);

            return chartData;
        }

        public static LinearChartData AddLine(this LinearChartData chartData, string lineName, IEnumerable<double> lineData)
        {
            return AddLine(chartData, lineName, new LineData { Data = lineData });
        }

        public static LinearChartData SetBaseLine(this LinearChartData chartData, string xAxisName, IEnumerable<double> xAxisMmarkers)
        {
            chartData.BaseLineData = new LineData { Data = xAxisMmarkers };
            chartData.BaseLineName = xAxisName;

            return chartData;
        }
    }
}
