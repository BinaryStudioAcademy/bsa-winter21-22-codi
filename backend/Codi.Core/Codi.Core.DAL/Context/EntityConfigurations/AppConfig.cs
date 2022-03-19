using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.DAL.Context.EntityConfigurations
{
    public class AppConfig : IEntityTypeConfiguration<App>
    {
        public void Configure(EntityTypeBuilder<App> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(100);

            builder.Property(e => e.DisplayName)
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .HasMaxLength(1000);

            builder.Property(e => e.AppDocumentId)
                .HasMaxLength(24);

            builder
                .HasMany(p => p.Tags)
                .WithMany(p => p.Apps)
                .UsingEntity<AppTag>(
                    j => j
                        .HasOne(pt => pt.Tag)
                        .WithMany(t => t.AppTags)
                        .HasForeignKey(pt => pt.TagId),
                    j => j
                        .HasOne(pt => pt.App)
                        .WithMany(p => p.AppTags)
                        .HasForeignKey(pt => pt.AppId),
                    j =>
                    {
                        j.HasKey(t => new { t.AppId, t.TagId });
                    });
        }
    }
}
