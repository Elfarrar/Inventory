using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Template.Data.Mapping
{
    public class TemplateMapping : IEntityTypeConfiguration<Model.Template>
    {
        public void Configure(EntityTypeBuilder<Model.Template> builder)
        {
            builder.ToTable("Templates");
        }
    }
}
