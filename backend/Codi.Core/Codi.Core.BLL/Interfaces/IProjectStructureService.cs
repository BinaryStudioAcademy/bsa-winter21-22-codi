namespace Codi.Core.BLL.Interfaces;

public interface IProjectStructureService
{
    void DeleteTempFolder(string path);
    Task<Guid> CreateProjectStructureFromFolder(string tempFolder);
}