namespace Codi.Core.DAL.Entities.Common
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }
}
