using Identity.Helpers;

namespace Identity.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAutenticationHelper, AutenticationHelper>();
        }
    }
}
