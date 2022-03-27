using Codi.Core.BLL.Models;
using Codi.Core.Common.DTO.Course;
using Codi.Core.Common.Enums;
using Codi.Core.DAL.Entities;
using System.Linq.Expressions;

namespace Codi.Core.BLL.Interfaces;

public interface ICourseService
{
    Task<CourseDto> CreateCourseAsync(CreateCourseDto courseDto);
    Task<CourseDto> GetCourseByIdAsync(long id);
    Task<CourseDto> UpdateCourseAsync(UpdateCourseDto courseDto);
    Task DeleteCourseAsync(long id);
    Task LeaveCourseAsync(LeaveCourseDto leaveCourseDto);
    Task<CourseDto> GetCourseByNameAsync(string courseName);
    Task<CourseUserDto> InviteCourseUserAsync(InviteCourseUserDto inviteCourseUserDto);
    Task<CourseUserDto> GetInviteCourseUserByIdAsync(long userId, long courseId);
    Task<PaginatedList<CourseUserDto>> GetAllCourseUsers(long courseId, int pageNumber, int pageSize,
            Expression<Func<CourseUser, bool>>? predicate = null,
            Expression<Func<CourseUser, object>>? orderBy = null,
            SortOrder sortOrder = SortOrder.Ascending);
    Task<CourseUserDto> ChangeCourseUserRoleAsync(InviteCourseUserDto userRole);
    Task<bool> GetCourseNameForValidatorAsync(string name);
}