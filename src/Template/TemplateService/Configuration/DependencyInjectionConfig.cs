using TemplateService.Data;
using TemplateService.Repository;

namespace TemplateService.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ITemplateServiceRepository, TemplateServiceRepository>();
            services.AddScoped<TemplateServiceContext>();
        }
    }
}
