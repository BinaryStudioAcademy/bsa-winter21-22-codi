using AutoMapper;
using Codi.Core.Common.DTO.Structure;
using Codi.Core.DAL.NoSql.Entities;

namespace Codi.Core.BLL.MappingProfiles;

public class StructureProfile : Profile
{
    public StructureProfile()
    {
        CreateMap<FSNode, FSNodeDto>()
            .ForMember(d => d.Children, opt => opt.MapFrom((s => s.Nodes)));
        CreateMap<Project, ProjectStructureDto>()
            .ForMember(d => d.Children, opt => opt.MapFrom(s => s.Nodes));
    }
}