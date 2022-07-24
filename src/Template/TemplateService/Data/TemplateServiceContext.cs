using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace TemplateService.Data
{
    public class TemplateServiceContext : ApplicationContext
    {
        public TemplateServiceContext(DbContextOptions options) : base(options) { }

        public DbSet<Model.TemplateService> WebAPITemplate { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TemplateServiceContext).Assembly);
        }
    }
}
