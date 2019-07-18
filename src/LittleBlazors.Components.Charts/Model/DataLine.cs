using System.Collections;

namespace LittleBlazors.Components.Charts.Model
{
    public class DataLine
    {
        public string LineName { get; set; }

        public ChartDataType Type { get; set; }

        public IEnumerable Data { get; set; }
    }
}
