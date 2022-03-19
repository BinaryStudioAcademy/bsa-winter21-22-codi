namespace Codi.Core.DAL.Entities
{
    public class Project : AuditEntity<long>
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public bool IsPublic { get; set; }

        public Guid ProjectDocumentId { get; set; }
        public long OwnerId { get; set; }
        public User Owner { get; set; } = default!;
        public List<Thread> Threads { get; set; } = default!;
        public List<InvitedUser> InvitedUsers { get; set; } = default!;
    }
}
