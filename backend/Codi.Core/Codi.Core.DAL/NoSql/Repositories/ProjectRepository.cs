using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;

namespace Codi.Core.DAL.NoSql.Repositories
{
    public class ProjectRepository : BaseMongoRepository<Project>, IProjectRepository
    {
        public ProjectRepository(IMongoContext context) : base(context)
        {
        }
    }
}