using Codi.Core.Common.Enums;
using MongoDB.Bson;

namespace Codi.Core.DAL.NoSql.Entities
{
    public class FSNode
    {
        public FSNodeType Type { get; set; }
        public string? Name { get; set; }
        public ObjectId? FileId { get; set; }
        public ICollection<FSNode> Nodes { get; set; }

        public FSNode()
        {
            Nodes = new List<FSNode>();
        }
    }
}
