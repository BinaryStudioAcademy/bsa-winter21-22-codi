namespace Codi.Core.DAL.Entities
{
    public class User : AuditEntity<long>
    {
        public string FirebaseId { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Bio { get; set; }
        public string Email { get; set; } = default!;

        public long? AvatarId { get; set; }
        public Image? Avatar { get; set; }
        public string? AccessToken { get; set; }
        public List<UserProject> UserProjects { get; set; } = default!;
        public List<CourseUser> CourseUsers { get; set; } = default!;
        public List<Submission> Submissions { get; set; } = default!;
        public List<ThreadComment> ThreadComments { get; set; } = default!;
        public List<Thread> Threads { get; set; } = default!;
        public List<Organization> Organizations { get; set; } = default!;
        public List<App> Apps { get; set; } = default!;
    }
}
