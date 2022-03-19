using AutoMapper;
using Codi.Core.Common.DTO.File;
using File = Codi.Core.DAL.NoSql.Entities.File;

namespace Codi.Core.BL.MappingProfiles;

public class FileProfile : Profile
{
    public FileProfile()
    {
        CreateMap<CreateFileDto, File>();
        CreateMap<File, FileDto>();
    }
}