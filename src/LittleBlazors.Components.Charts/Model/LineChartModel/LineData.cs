using System.Collections;

namespace LittleBlazors.Components.Charts.Model.LineChartModel
{
    public class LineData
    {
        public string LineName { get; set; }

        public ChartDataType Type { get; set; }

        public IEnumerable Data { get; set; }
    }
}
