using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;

namespace Codi.Core.DAL.NoSql.Repositories
{
    public class AppRepository : BaseMongoRepository<App>, IAppRepository
    {
        public AppRepository(IMongoContext context) : base(context)
        {
        }
    }
}
