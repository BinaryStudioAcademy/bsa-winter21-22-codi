namespace Codi.Core.DAL.Entities
{
    public class InvitedUser : AuditEntity<long>
    {
        public long ProjectId { get; set; }
        public Project Project { get; set; } = default!;
        public long UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
