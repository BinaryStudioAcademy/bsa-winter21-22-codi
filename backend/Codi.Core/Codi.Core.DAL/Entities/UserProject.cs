namespace Codi.Core.DAL.Entities;

public class UserProject : AuditEntity<long>
{
    public long UserId { get; set; }
    public User User { get; set; } = default!;
    public long ProjectId { get; set; }
    public Project Project { get; set; } = default!;
    public long? SubmissionId { get; set; }
    public Submission Submission { get; set; } = default!;
}