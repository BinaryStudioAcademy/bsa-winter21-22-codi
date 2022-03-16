using Codi.Core.DAL.Entities;

namespace Codi.Core.DAL.Entities
{
    public class App : AuditEntity<long>
    {
        public string Name { get; set; } = default!;
        public string? DisplayName { get; set; }
        public string? Description { get; set; }

        public Guid AppDocumentId { get; set; }
        public long? ImageId { get; set; }
        public Image? Image { get; set; }
        public long OwnerId { get; set; }
        public User Owner { get; set; } = default!;
        public List<Tag> Tags { get; set; } = default!;
        public List<AppTag> AppTags { get; set; } = default!;
    }
}
