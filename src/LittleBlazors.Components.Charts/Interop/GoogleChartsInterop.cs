using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
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

        public Task DrawPieAsync(IDictionary<string, double> data, ElementRef container)
        {
            return this.jsRuntime.InvokeAsync<object>("littleBlazors.drawPieChart", data, container);
        }

        public Task DrawLineAsync(IDictionary<string, double> data, ElementRef container)
        {
            return this.jsRuntime.InvokeAsync<object>("littleBlazors.drawLineChart", data, container);
        }
    }
}
