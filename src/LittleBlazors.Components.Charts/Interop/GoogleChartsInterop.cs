using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace LittleBlazors.Components.Charts.Interop
{
    internal class GoogleChartsInterop
    {
        private static bool chartsInitialized = false;
        private readonly IJSRuntime jsRuntime;

        public GoogleChartsInterop(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public Task InitializeCharts(ElementRef container)
        {
            if (chartsInitialized)
                return Task.CompletedTask;

            chartsInitialized = true;
            return this.jsRuntime.InvokeAsync<int>("littleBlazors.init", container);
        }
    }
}
