using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using File = Codi.Core.DAL.NoSql.Entities.File;

namespace Codi.Core.DAL.NoSql.Repositories
{
    public class FileRepository : BaseMongoRepository<File>, IFileRepository
    {
        public FileRepository(IMongoContext context) : base(context)
        {
        }
    }
}
