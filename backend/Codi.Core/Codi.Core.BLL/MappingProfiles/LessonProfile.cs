using AutoMapper;
using Codi.Core.Common.DTO.Lesson;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class LessonProfile : Profile
    {
        public LessonProfile()
        {
            CreateMap<Lesson, LessonDto>().ReverseMap();
        }
    }
}
