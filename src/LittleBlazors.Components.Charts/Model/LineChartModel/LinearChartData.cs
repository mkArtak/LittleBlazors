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

        public IDictionary<string, DataLine> Lines { get; set; } = new Dictionary<string, DataLine>(1);
    }
}
