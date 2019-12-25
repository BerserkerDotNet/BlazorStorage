using BlazorStorage.Interfaces;
using Microsoft.JSInterop;

namespace BlazorStorage.Services
{
    public class SessionStorage : Storage, ISessionStorage
    {
        public SessionStorage(IJSRuntime jsRuntime)
            : base("sessionStorage", jsRuntime)
        {
        }
    }
}
