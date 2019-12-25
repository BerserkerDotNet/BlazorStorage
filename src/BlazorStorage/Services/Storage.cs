using System.Threading.Tasks;
using BlazorStorage.Interfaces;
using Microsoft.JSInterop;

namespace BlazorStorage.Services
{
    public abstract class Storage : IStorage
    {
        private readonly string _storageType;
        private readonly IJSRuntime _jsRuntime;

        public Storage(string storageType, IJSRuntime jsRuntime)
        {
            _storageType = storageType;
            _jsRuntime = jsRuntime;
        }

        public ValueTask Clear()
        {
            return _jsRuntime.InvokeVoidAsync($"{_storageType}.clear");
        }

        public ValueTask<T> GetItem<T>(string key)
        {
            return _jsRuntime.InvokeAsync<T>($"{_storageType}.getItem", key);
        }

        public ValueTask<string> Key(int index)
        {
            return _jsRuntime.InvokeAsync<string>($"{_storageType}.key", index);
        }

        public ValueTask RemoveItem(string key)
        {
            return _jsRuntime.InvokeVoidAsync($"{_storageType}.removeItem", key);
        }

        public ValueTask SetItem<T>(string key, T value)
        {
            return _jsRuntime.InvokeVoidAsync($"{_storageType}.setItem", key, value);
        }
    }
}
