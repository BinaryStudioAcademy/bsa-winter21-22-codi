using AutoMapper;
using Codi.Core.BL.Interfaces;
using Codi.Core.BLL.Exceptions;
using Codi.Core.Common.DTO.File;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using File = Codi.Core.DAL.NoSql.Entities.File;

namespace Codi.Core.BL.Services;

public class FileService : IFileService
{
    private readonly IFileRepository _fileRepository;
    private readonly IMapper _mapper;
    
    public FileService(
        IFileRepository fileRepository,
        IMapper mapper)
    {
        _fileRepository = fileRepository;
        _mapper = mapper;
    }
    
    public async Task<FileDto> CreateFileAsync(CreateFileDto fileCreateDto)
    {
        var fileCreate = _mapper.Map<File>(fileCreateDto);
        
        await _fileRepository.InsertOneAsync(fileCreate);
        
        return await GetByIdAsync(fileCreate.Id.ToString());
    }
    
    public async Task<FileDto> GetByIdAsync(string id)
    {
        var file = await _fileRepository.GetByIdAsync(id);
        if (file is null)
        {
            throw new NotFoundException(nameof(File));
        }

        var fileDto = _mapper.Map<FileDto>(file);

        return fileDto;
    }
}