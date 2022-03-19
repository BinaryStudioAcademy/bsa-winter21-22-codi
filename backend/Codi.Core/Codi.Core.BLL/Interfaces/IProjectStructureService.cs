namespace Codi.Core.BL.Interfaces;

public interface IProjectStructureService
{
    void DeleteTempFolder(string path);
    Task CreateProjectStructureFromFolder(string tempFolder);
}