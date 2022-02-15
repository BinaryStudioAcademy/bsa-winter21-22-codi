namespace Codi.Core.DAL.Entities
{
    public class ThreadComment : AuditEntity<long>
    {
        public string Body { get; set; } = default!;

        public long AuthorId { get; set; }
        public User Author { get; set; } = default!;

        public long ThreadId { get; set; }
        public Thread Thread { get; set; } = default!;
    }
}
