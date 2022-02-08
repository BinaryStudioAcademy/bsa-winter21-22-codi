namespace Codi.Core.DAL.Entities
{
    public class Image : AuditEntity<long>
    {
        public string URL { get; set; } = default!;
    }
}
