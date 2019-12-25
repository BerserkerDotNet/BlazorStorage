using BlazorStorage.Interfaces;
using Microsoft.JSInterop;

namespace BlazorStorage.Services
{
    public class LocalStorage : Storage, ILocalStorage
    {
        public LocalStorage(IJSRuntime jsRuntime)
            : base("localStorage", jsRuntime)
        {
        }
    }
}
