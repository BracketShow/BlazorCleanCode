using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorCleanCode.Client.Typescript
{
    public class UrlOpener
    {
        public static ValueTask OpenExternalLink(IJSRuntime jsRuntime, string url)
        {
            return jsRuntime.InvokeVoidAsync("UrlOpenerService.openExternalLink", url);
        }
    }
}
