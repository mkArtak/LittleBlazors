using System;
using System.Collections.Generic;

namespace LittleBlazors.Components.Charts.Model
{
    public static class ChartDataExtensions
    {
        public static ChartData AddLine(this ChartData chartData, DataLine lineData)
        {
            chartData.Lines.Add(lineData.LineName, lineData);

            return chartData;
        }

        public static ChartData AddLine<T>(this ChartData chartData, string lineName, System.Collections.Generic.IEnumerable<T> lineData) where T : struct
        {
            return AddLine(chartData, new DataLine { Data = lineData, LineName = lineName, Type = ToLineChartType<T>() });
        }

        private static readonly IDictionary<Type, ChartDataType> typeMappings = new Dictionary<Type, ChartDataType>() {
            { typeof(int), ChartDataType.Number },
            { typeof(double), ChartDataType.Number },
            { typeof(float), ChartDataType.Number },
            { typeof(string), ChartDataType.String },
            { typeof(bool), ChartDataType.Boolean},
            { typeof(DateTime), ChartDataType.Date},
            { typeof(DateTimeOffset), ChartDataType.DateTime},
            { typeof(TimeSpan), ChartDataType.Time},
        };

        private static ChartDataType ToLineChartType<T>()
        {
            return typeMappings[typeof(T)];
        }
    }
}
