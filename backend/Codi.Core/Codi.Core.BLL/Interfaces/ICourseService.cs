using Codi.Core.Common.DTO.Course;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.Interfaces;

public interface ICourseService
{
    Task<ICollection<CourseDto>> GetAllCoursesAsync();
    Task<CourseDto> CreateCourseAsync(CreateCourseDto courseDto);
    Task<CourseDto> GetCourseAsync(string name);
    Task<CourseDto> UpdateCourseAsync(UpdateCourseDto courseDto);
    Task DeleteCourseAsync(long id);
    Task LeaveCourseAsync(LeaveCourseDto leaveCourseDto);
}