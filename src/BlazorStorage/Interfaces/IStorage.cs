using System.Threading.Tasks;

namespace BlazorStorage.Interfaces
{
    public interface IStorage
    {
        ValueTask SetItem<T>(string key, T value);

        ValueTask<T> GetItem<T>(string key);

        ValueTask RemoveItem(string key);

        ValueTask Clear();

        ValueTask<string> Key(int index);
    }
}
