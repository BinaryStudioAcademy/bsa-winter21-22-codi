using Codi.Core.Common.DTO.Course;

namespace Codi.Core.BL.Interfaces;

public interface ICourseService
{
    Task<CourseDto> CreateCourseAsync(CreateCourseDto courseDto);
    Task<CourseDto> GetCourseByIdAsync(long id);
    Task<CourseDto> UpdateCourseAsync(UpdateCourseDto courseDto);
    Task DeleteCourseAsync(long id);
    Task LeaveCourseAsync(LeaveCourseDto leaveCourseDto);
}