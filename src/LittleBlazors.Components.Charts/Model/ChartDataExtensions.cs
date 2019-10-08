using System;
using System.Collections.Generic;
using System.Linq;

namespace LittleBlazors.Components.Charts.Model
{
    public static class ChartDataExtensions
    {
        public static ChartData AddLine<T>(this ChartData chartData, string lineName, IEnumerable<T> lineData)
        {
            System.Collections.IEnumerable data = lineData;
            if (typeof(T) == typeof(DateTimeOffset))
            {
                data = lineData.OfType<DateTimeOffset>().Select(item => item.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            }
            else if (typeof(T) == typeof(DateTime))
            {
                data = lineData.OfType<DateTime>().Select(item => item.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            }
            else
            {
                data = lineData;
            }

            chartData.Lines.Add(lineName, new DataLine { Data = data, LineName = lineName, Type = ToLineChartType<T>() });
            return chartData;
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
