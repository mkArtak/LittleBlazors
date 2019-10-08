using System;
using System.Collections.Generic;
using System.Linq;

namespace LittleBlazors.Components.Charts.Model
{
    public class PieChartData
    {
        private ICollection<Tuple<string, double>> data = new List<Tuple<string, double>>();

        public string Title { get; set; }

        public PieChartData AddPieSection(string section, double value)
        {
            data.Add(Tuple.Create(section, value));
            return this;
        }

        public ChartData ToChartData()
        {
            ChartData result = new ChartData() { Title = this.Title }
            .AddLine<string>(Guid.NewGuid().ToString(), this.data.Select(d => d.Item1));

            result.AddLine<double>(Guid.NewGuid().ToString(), this.data.Select(d => d.Item2));

            return result;
        }
    }
}
