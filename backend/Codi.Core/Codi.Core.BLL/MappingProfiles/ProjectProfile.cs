using AutoMapper;
using Codi.Core.Common.DTO.Project;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<Project, ProjectDto>().ReverseMap();
        }
    }
}
