using Codi.Core.DAL.NoSql.Entities;
using File = Codi.Core.DAL.NoSql.Entities.File;

namespace Codi.Core.DAL.NoSql.Repositories.Abstract
{
    public interface IFileRepository : IMongoRepository<File>
    {
        Task<ICollection<FSNode>> DublicateFileStructure(ICollection<FSNode> nodes);
        Task DeleteFiles(ICollection<FSNode> nodes);
    }
}
