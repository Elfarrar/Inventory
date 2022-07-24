using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Category.Data.Mapping
{
    public class CategoryMapping : IEntityTypeConfiguration<Model.Category>
    {
        public void Configure(EntityTypeBuilder<Model.Category> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.ToTable("Categorys");
        }
    }
}
