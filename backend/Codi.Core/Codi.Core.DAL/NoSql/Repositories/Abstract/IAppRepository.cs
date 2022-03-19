using Codi.Core.DAL.NoSql.Entities;

namespace Codi.Core.DAL.NoSql.Repositories.Abstract
{
    public interface IAppRepository : IMongoRepository<App>
    {
    }
}
