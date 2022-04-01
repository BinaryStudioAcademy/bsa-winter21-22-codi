using AutoMapper;
using Codi.Core.Common.DTO.Lesson;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BLL.MappingProfiles
{
    public sealed class LessonProfile : Profile
    {
        public LessonProfile()
        {
            CreateMap<Lesson, LessonDto>();
            CreateMap<CreateLessonDto, Lesson>();
        }
    }
}
