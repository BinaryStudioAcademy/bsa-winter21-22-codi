using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codi.Core.DAL.Context.EntityConfigurations
{
    public class CourseRoleConfig : IEntityTypeConfiguration<CourseRole>
    {
        public void Configure(EntityTypeBuilder<CourseRole> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(15);
        }
    }
}
