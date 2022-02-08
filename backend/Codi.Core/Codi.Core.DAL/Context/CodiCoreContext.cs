using Codi.Core.DAL.Context;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Thread = Codi.Core.DAL.Entities.Thread;

namespace Codi.Core.DAL
{
    public class CodiCoreContext : DbContext
    {
        public DbSet<Sample> Samples { get; private set; } = default!;
        public DbSet<Course> Courses { get; private set; } = default!;
        public DbSet<CourseRole> CourseRoles { get; private set; } = default!;
        public DbSet<CourseUser> CourseUsers { get; private set; } = default!;
        public DbSet<Image> Images { get; private set; } = default!;
        public DbSet<InvitedUser> InvitedUsers { get; private set; } = default!;
        public DbSet<Lesson> Lessons { get; private set; } = default!;
        public DbSet<Project> Projects { get; private set; } = default!;
        public DbSet<Submission> Submissions { get; private set; } = default!;
        public DbSet<Thread> Threads { get; private set; } = default!;
        public DbSet<ThreadComment> ThreadComments { get; private set; } = default!;
        public DbSet<Unit> Units { get; private set; } = default!;
        public DbSet<User> Users { get; private set; } = default!;

        public CodiCoreContext(DbContextOptions<CodiCoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();
            modelBuilder.Seed();
        }
    }
}