using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;

namespace Codi.Core.DAL.NoSql.Repositories
{
    public class TemplateRepository : BaseMongoRepository<Template>, ITemplateRepository
    {
        public TemplateRepository(IMongoContext context) : base(context)
        {
        }
    }
}
