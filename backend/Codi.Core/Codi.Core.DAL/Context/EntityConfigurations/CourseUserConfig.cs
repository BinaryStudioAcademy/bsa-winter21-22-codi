using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codi.Core.DAL.Context.EntityConfigurations
{
    public class CourseUserConfig : IEntityTypeConfiguration<CourseUser>
    {
        public void Configure(EntityTypeBuilder<CourseUser> builder)
        {
            builder.HasOne(cu => cu.User)
                .WithMany(u => u.CourseUsers)
                .HasForeignKey(cu => cu.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
