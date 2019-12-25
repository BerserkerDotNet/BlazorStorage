using BlazorStorage.Extensions;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorStorage.Samples
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddStorage();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
