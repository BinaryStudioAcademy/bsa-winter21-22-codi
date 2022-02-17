namespace Codi.Core.DAL.Entities
{
    public class CourseRole : AuditEntity<long>
    {
        public string Name { get; set; } = default!;
    }
}
