using Codi.Core.Common.DTO.File;

namespace Codi.Core.BLL.Interfaces;

public interface IFileService
{
    Task<FileDto> CreateFileAsync(CreateFileDto fileCreateDto);
    Task<FileDto> GetByIdAsync(Guid id);
}