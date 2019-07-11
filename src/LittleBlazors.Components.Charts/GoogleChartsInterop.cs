using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace LittleBlazors.Components.Charts
{
    internal class GoogleChartsInterop
    {
        private static bool chartsInitialized = false;
        private readonly IJSRuntime jsRuntime;

        public GoogleChartsInterop(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task InitializeCharts(string container)
        {
            if (chartsInitialized)
                return;

            await this.jsRuntime.InvokeAsync<int>("jsInterop.initGoogleCharts", container);
            chartsInitialized = true;
        }
    }
}
