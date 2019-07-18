using LittleBlazors.Components.Charts.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace LittleBlazors.Components.Charts.Interop
{
    internal class GoogleChartsInterop
    {
        private readonly IJSRuntime jsRuntime;

        public GoogleChartsInterop(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public Task DrawPieAsync(PieChartData data, ElementRef container)
        {
            return this.jsRuntime.InvokeAsync<object>("littleBlazors.drawPieChart", data.ToChartData(), container);
        }

        public Task DrawLineAsync(ChartData data, ElementRef container)
        {
            return this.jsRuntime.InvokeAsync<object>("littleBlazors.drawLineChart", data, container);
        }
    }
}
