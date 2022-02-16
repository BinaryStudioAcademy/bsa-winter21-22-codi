using File = Codi.Core.DAL.NoSql.Entities.File;

namespace Codi.Core.DAL.NoSql.Repositories.Abstract
{
    public interface IFileRepository : IMongoRepository<File>
    {
    }
}
