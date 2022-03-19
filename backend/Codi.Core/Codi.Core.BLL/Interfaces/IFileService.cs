using Codi.Core.Common.DTO.File;

namespace Codi.Core.BL.Interfaces;

public interface IFileService
{
    Task<FileDto> CreateFileAsync(CreateFileDto fileCreateDto);
    Task<FileDto> GetByIdAsync(string id);
}