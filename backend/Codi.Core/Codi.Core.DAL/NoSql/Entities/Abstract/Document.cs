using MongoDB.Bson;

namespace Codi.Core.DAL.NoSql.Entities.Abstract
{
    public abstract class Document : IDocument
    {
        public Guid Id { get; set; }
    }
}
