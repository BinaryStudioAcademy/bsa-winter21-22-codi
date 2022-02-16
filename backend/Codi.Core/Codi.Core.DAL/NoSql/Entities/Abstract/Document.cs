using MongoDB.Bson;

namespace Codi.Core.DAL.NoSql.Entities.Abstract
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }
        public DateTime CreatedAt => Id.CreationTime;
    }
}
