using BlazorStorage.Interfaces;
using BlazorStorage.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorStorage.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddStorage(this IServiceCollection services)
        {
            services.AddSingleton<ILocalStorage, LocalStorage>();
            services.AddSingleton<ISessionStorage, SessionStorage>();
        }
    }
}
