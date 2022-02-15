using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codi.Core.DAL.Context.EntityConfigurations
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(100);

            builder.Property(e => e.DisplayName)
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .HasMaxLength(1000);
        }
    }
}
