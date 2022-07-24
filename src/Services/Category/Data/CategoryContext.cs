using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Category.Data
{
    public class CategoryContext : ApplicationContext
    {
        public CategoryContext(DbContextOptions options) : base(options) { }

        public DbSet<Model.Category> Categorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryContext).Assembly);
        }
    }
}
