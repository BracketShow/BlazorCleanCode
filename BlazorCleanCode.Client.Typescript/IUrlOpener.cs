using System.Threading.Tasks;

namespace BlazorCleanCode.Client.Typescript
{
    public interface IUrlOpener
    {
        ValueTask OpenExternalLink(string url);
    }
}