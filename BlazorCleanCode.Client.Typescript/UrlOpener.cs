using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorCleanCode.Client.Typescript
{
    public class UrlOpener : IUrlOpener
    {
        private readonly IJSRuntime _jsRuntime;

        public UrlOpener(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public ValueTask OpenExternalLink(string url)
        {
            return _jsRuntime.InvokeVoidAsync(
                "UrlOpenerService.openExternalLink", url);
        }
    }
}
