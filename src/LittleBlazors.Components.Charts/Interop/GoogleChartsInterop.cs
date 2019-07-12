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

        public Task DrawAsync(ElementRef container)
        {
            return this.jsRuntime.InvokeAsync<object>("littleBlazors.draw", container);
        }
    }
}
