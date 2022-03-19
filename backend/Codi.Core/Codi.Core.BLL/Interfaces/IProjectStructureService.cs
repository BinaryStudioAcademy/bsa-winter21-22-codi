namespace Codi.Core.BLL.Interfaces;

public interface IProjectStructureService
{
    void DeleteTempFolder(string path);
    Task CreateProjectStructureFromFolder(string tempFolder);
}