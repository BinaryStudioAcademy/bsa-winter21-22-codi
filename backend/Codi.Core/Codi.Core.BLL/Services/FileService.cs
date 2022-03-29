using AutoMapper;
using Codi.Core.BLL.Interfaces;
using Codi.Core.BLL.Exceptions;
using Codi.Core.Common.DTO.File;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using File = Codi.Core.DAL.NoSql.Entities.File;

namespace Codi.Core.BLL.Services;

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
    
    public async Task<FileDto> CreateFileAsync(CreateFileDto createFileDto)
    {
        var fileCreate = _mapper.Map<File>(createFileDto);
        
        await _fileRepository.InsertOneAsync(fileCreate);
        
        return await GetByIdAsync(fileCreate.Id);
    }

    public async Task<FileDto> UpdateFileAsync(UpdateFileDto updateFileDto)
    {
        var existedFile = await _fileRepository.GetByIdAsync(updateFileDto.Id);
        if (existedFile is null)
        {
            throw new NotFoundException(nameof(File));
        }

        var mergedFile = _mapper.Map(updateFileDto, existedFile);

        await _fileRepository.ReplaceOneAsync(mergedFile);

        return _mapper.Map<FileDto>(await _fileRepository.GetByIdAsync(updateFileDto.Id));
    }

    public async Task<FileDto> GetByIdAsync(Guid id)
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