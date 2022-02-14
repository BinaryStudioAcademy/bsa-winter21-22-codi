using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codi.Core.DAL.Context.EntityConfigurations
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(e => e.Title)
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .HasMaxLength(1000);
        }
    }
}
