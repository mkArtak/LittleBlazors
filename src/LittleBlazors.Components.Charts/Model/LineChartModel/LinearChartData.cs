using System.Collections.Generic;

namespace LittleBlazors.Components.Charts.Model.LineChartModel
{
    public class LinearChartData
    {
        public LinearChartData()
        {

        }

        public string BaseLineName { get; set; }

        public LineData BaseLineData { get; set; }

        public IDictionary<string, LineData> Lines { get; set; } = new Dictionary<string, LineData>(1);
    }
}
