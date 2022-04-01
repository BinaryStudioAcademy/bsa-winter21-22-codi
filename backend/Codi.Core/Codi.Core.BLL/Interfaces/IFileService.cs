using Codi.Core.Common.DTO.File;

namespace Codi.Core.BLL.Interfaces;

public interface IFileService
{
    Task<FileDto> CreateFileAsync(CreateFileDto createFileDto);
    Task<FileDto> UpdateFileAsync(UpdateFileDto updateFileDto);
    Task<FileDto> GetByIdAsync(Guid id);
}