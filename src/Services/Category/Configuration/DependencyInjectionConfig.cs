using Category.Data;
using Category.Repository;
using Repository.Context;

namespace Category.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<CategoryContext>();
        }
    }
}
