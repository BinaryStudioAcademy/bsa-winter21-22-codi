using Codi.Core.Common.DTO.Structure;

namespace Codi.Core.BLL.Interfaces;

public interface IProjectStructureService
{
    void DeleteTempFolder(string path);
    Task<Guid> CreateProjectStructureFromFolder(string tempFolder);
    Task<ProjectStructureDto> GetProjectStructureByIdAsync(long projectId);
}