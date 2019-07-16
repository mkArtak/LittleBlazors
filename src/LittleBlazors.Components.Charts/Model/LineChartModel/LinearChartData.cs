using System.Collections.Generic;

namespace LittleBlazors.Components.Charts.Model.LineChartModel
{
    public class LinearChartData
    {
        public LinearChartData()
        {

        }

        /// <summary>
        /// Gets or sets the chart title
        /// </summary>
        public string Title { get; set; }

        public LineData BaseLineData { get; set; }

        public IDictionary<string, LineData> Lines { get; set; } = new Dictionary<string, LineData>(1);
    }
}
