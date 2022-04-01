using AutoMapper;
using Codi.Core.Common.DTO.Lesson;
using Codi.Core.Common.DTO.Project;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BLL.MappingProfiles
{
    public sealed class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<Project, ProjectNameDto>();
            CreateMap<Project, ProjectWithLanguageDto>();
            CreateMap<NewProjectDto, Project>();
            CreateMap<UpdateProjectDto, Project>();
            CreateMap<CreateLessonDto, NewProjectDto>();
        }
    }
}
