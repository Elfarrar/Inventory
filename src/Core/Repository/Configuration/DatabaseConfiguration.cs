using Microsoft.Extensions.DependencyInjection;

namespace Repository.Configuration
{
    public static class DatabaseConfiguration
    {
        public static void DbConfig<TContext>(this IServiceCollection services, string connectionString) where TContext : ApplicationContext
        {
            services.AddDbContext<TContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
