using Codi.Core.Common.Enums;
using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using File = Codi.Core.DAL.NoSql.Entities.File;

namespace Codi.Core.DAL.NoSql.Repositories
{
    public class FileRepository : BaseMongoRepository<File>, IFileRepository
    {
        public FileRepository(IMongoContext context) : base(context)
        {
        }

        public Task DeleteFiles(ICollection<FSNode> nodes)
        {
            return DeleteFSNodes(nodes);
        }

        public Task<ICollection<FSNode>> DublicateFileStructure(ICollection<FSNode> nodes)
        {
            return DublicateFSNodes(nodes);
        }

        private async Task<ICollection<FSNode>> DublicateFSNodes(ICollection<FSNode> nodes)
        {
            var list = new List<FSNode>();

            foreach (var node in nodes)
            {
                if (node.Type == FSNodeType.File)
                {
                    var newFile = await DublicateFile(node.FileId!.Value);

                    list.Add(new FSNode
                    {
                        Type = FSNodeType.File,
                        Name = node.Name,
                        FileId = newFile.Id
                    });
                }

                if (node.Type == FSNodeType.Folder)
                {
                    list.Add(new FSNode
                    {
                        Type = FSNodeType.Folder,
                        Name = node.Name,
                        Nodes = await DublicateFSNodes(node.Nodes!)
                    });
                }
            }

            return list;
        }

        private async Task<File> DublicateFile(Guid fileId)
        {
            var file = await GetByIdAsync(fileId);
            file.Id = Guid.NewGuid();

            await InsertOneAsync(file);

            return file;
        }

        private async Task DeleteFSNodes(ICollection<FSNode> nodes)
        {
            var fileIds = new List<Guid>();

            foreach (var node in nodes)
            {
                if (node.Type == FSNodeType.File)
                {
                    fileIds.Add(node.FileId!.Value);
                }
            }

            await DeleteManyAsync(f => fileIds.Contains(f.Id));
        }
    }
}
