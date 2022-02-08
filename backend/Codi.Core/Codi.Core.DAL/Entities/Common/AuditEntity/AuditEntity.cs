using Codi.Core.DAL.Entities.Common;

namespace Codi.Core.DAL.Entities
{
    public abstract class AuditEntity<T> : Entity<T>, ISoftDeletable where T : struct
    {
        public T? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
