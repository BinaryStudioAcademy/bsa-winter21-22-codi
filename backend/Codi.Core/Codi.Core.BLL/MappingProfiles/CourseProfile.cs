using AutoMapper;
using Codi.Core.Common.DTO.Course;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDto>()
                .ForMember(p => p.Avatar, o => o.MapFrom(c => c.Avatar == null ? "" : c.Avatar.URL));
            CreateMap<CreateCourseDto, Course>();
            CreateMap<UpdateCourseDto, Course>();
            CreateMap<CourseUser, CourseUserDto>().ReverseMap();
            CreateMap<InviteCourseUserDto, CourseUser>(); 
        }
    }
}
