using Codi.Core.DAL.NoSql.Attributes;
using Codi.Core.DAL.NoSql.Entities.Abstract;

namespace Codi.Core.DAL.NoSql.Entities
{
    [BsonCollection("projects")]
    public class Project : Document
    {
        public Guid TemplateId { get; set; }
        public ICollection<FSNode> Nodes { get; set; } = default!;
    }
}
