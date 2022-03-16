namespace Codi.Core.DAL.Entities
{
    public class AppTag : AuditEntity<long>
    {
        public long AppId { get; set; }
        public App App { get; set; } = default!;
        public long TagId { get; set; }
        public Tag Tag { get; set; } = default!;
    }
}
