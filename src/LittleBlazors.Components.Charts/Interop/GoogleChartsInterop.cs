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

        public async Task DrawPieAsync(PieChartData data, ElementReference container)
        {
            await this.jsRuntime.InvokeAsync<object>("littleBlazors.drawPieChart", data.ToChartData(), container);
        }

        public async Task DrawLineAsync(ChartData data, ElementReference container)
        {
            await this.jsRuntime.InvokeAsync<object>("littleBlazors.drawLineChart", data, container);
        }
    }
}
