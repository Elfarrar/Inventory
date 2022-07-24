using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TemplateService.Data.Mapping
{
    public class TemplateServiceMapping : IEntityTypeConfiguration<Model.TemplateService>
    {
        public void Configure(EntityTypeBuilder<Model.TemplateService> builder)
        {
            builder.ToTable("TemplateServices");
        }
    }
}
