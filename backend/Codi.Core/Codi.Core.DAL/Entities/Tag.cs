namespace Codi.Core.DAL.Entities
{
    public class Tag : AuditEntity<long>
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public List<App> Apps { get; set; } = default!;
        public List<AppTag> AppTags { get; set; } = default!;
    }
}
