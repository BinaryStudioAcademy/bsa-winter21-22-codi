using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Codi.Core.DAL.NoSql.Entities.Abstract
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreatedAt { get; }
    }
}
