namespace Codi.Core.DAL.Entities;

public class Organization : AuditEntity<long>
{
    public string Name { get; set; } = default!;
    public long OwnerId { get; set; }
    public User Owner { get; set; } = default!;
    public List<Course> Courses { get; set; } = default!;
}