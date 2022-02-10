using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codi.Core.DAL.Context.EntityConfigurations
{
    public class InvitedUserConfig : IEntityTypeConfiguration<InvitedUser>
    {
        public void Configure(EntityTypeBuilder<InvitedUser> builder)
        {
            builder.HasKey(iu => new { iu.ProjectId, iu.UserId });

            builder.HasOne(iu => iu.User)
                .WithMany(u => u.InvitedUsers)
                .HasForeignKey(iu => iu.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
