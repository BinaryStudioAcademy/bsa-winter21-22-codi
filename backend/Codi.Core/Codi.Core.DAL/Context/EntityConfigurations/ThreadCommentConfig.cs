using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codi.Core.DAL.Context.EntityConfigurations
{
    public class ThreadCommentConfig : IEntityTypeConfiguration<ThreadComment>
    {
        public void Configure(EntityTypeBuilder<ThreadComment> builder)
        {
            builder.HasOne(tc => tc.Author)
                .WithMany(u => u.ThreadComments)
                .HasForeignKey(s => s.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.Body)
                .HasMaxLength(2000);
        }
    }
}
