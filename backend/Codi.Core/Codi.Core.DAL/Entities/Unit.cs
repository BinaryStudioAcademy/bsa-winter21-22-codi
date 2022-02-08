namespace Codi.Core.DAL.Entities
{
    public class Unit : AuditEntity<long>
    {
        public string Title { get; set; } = default!;
    }
}
