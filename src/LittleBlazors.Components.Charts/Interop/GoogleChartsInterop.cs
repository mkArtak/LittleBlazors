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

        public Task InitializeCharts(ElementRef container)
        {
            return this.jsRuntime.InvokeAsync<object>("littleBlazors.init", container);
        }
    }
}
