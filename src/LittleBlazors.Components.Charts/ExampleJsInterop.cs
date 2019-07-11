using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace LittleBlazors.Components.Charts
{
    public class ExampleJsInterop
    {
        public static Task<string> Prompt(IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                message);
        }
    }
}
