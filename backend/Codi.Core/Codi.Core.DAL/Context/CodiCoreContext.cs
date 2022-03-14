using Codi.Core.DAL.Context;
using Codi.Core.DAL.Entities;
using Codi.Core.DAL.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Thread = Codi.Core.DAL.Entities.Thread;

namespace Codi.Core.DAL
{
    public class CodiCoreContext : DbContext
    {
        public DbSet<Sample> Samples { get; private set; }
        public DbSet<Course> Courses { get; private set; }
        public DbSet<CourseUser> CourseUsers { get; private set; }
        public DbSet<Image> Images { get; private set; }
        public DbSet<InvitedUser> InvitedUsers { get; private set; }
        public DbSet<Lesson> Lessons { get; private set; }
        public DbSet<Organization> Organizations { get; private set; }
        public DbSet<Project> Projects { get; private set; }
        public DbSet<Submission> Submissions { get; private set; }
        public DbSet<Thread> Threads { get; private set; }
        public DbSet<ThreadComment> ThreadComments { get; private set; }
        public DbSet<Unit> Units { get; private set; }
        public DbSet<User> Users { get; private set; }

        public CodiCoreContext(DbContextOptions<CodiCoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();
            modelBuilder.Seed();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaveChanges();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {
            OnBeforeSaveChanges();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaveChanges()
        {
            var markedAsDeleted = ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            foreach (var item in markedAsDeleted)
            {
                if (item.Entity is ISoftDeletable entity)
                {
                    item.State = EntityState.Unchanged;
                    entity.IsDeleted = true;
                }
            }
        }
    }
}
