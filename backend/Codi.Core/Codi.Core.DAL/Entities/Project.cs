﻿using Codi.Core.Common.Enums;

namespace Codi.Core.DAL.Entities
{
    public class Project : AuditEntity<long>
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public bool IsPublic { get; set; }

        public Guid ProjectDocumentId { get; set; }
        public Language? Language { get; set; }

        public List<UserProject> UserProjects { get; set; } = default!;
        public List<Lesson> Lessons { get; set; } = default!;
        public List<Thread> Threads { get; set; } = default!;
        public List<InvitedUser> InvitedUsers { get; set; } = default!;
    }
}
