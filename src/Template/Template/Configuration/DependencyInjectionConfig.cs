using Repository.Context;
using Template.Data;
using Template.Repository;

namespace Template.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ITemplateRepository, TemplateRepository>();
            services.AddScoped<TemplateContext>();
        }
    }
}
