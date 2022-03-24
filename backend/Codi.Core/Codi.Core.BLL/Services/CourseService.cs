using AutoMapper;
using AutoMapper.QueryableExtensions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.BLL.Exceptions;
using Codi.Core.BLL.Extentions;
using Codi.Core.BLL.Models;
using Codi.Core.Common.DTO.Course;
using Codi.Core.Common.Enums;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Codi.Core.BLL.Services;

public class CourseService : BaseService, ICourseService
{
    public CourseService(CodiCoreContext context, IMapper mapper) : base(context, mapper) { }

    public async Task<CourseDto> CreateCourseAsync(CreateCourseDto courseDto)
    {
        var existedCourse = await _context.Courses.FirstOrDefaultAsync(c => c.Name == courseDto.Name);
        if (existedCourse is not null)
        {
            throw new InvalidOperationException($"Course with name {courseDto.Name} already exists.");
        }
        
        var course = _mapper.Map<Course>(courseDto, opts => opts.AfterMap((src, dst) =>
        {
            dst.CreatedAt = DateTime.Now;
        }));

        var createdCourse = _context.Add(course).Entity;
        await _context.SaveChangesAsync();
        
        var courseUser = new CourseUser()
        {
            CourseId = createdCourse.Id,
            UserId = courseDto.OwnerId,
            CourseRole = CourseRole.Admin,
            CreatedAt = DateTime.Now
        };
        
        _context.Add(courseUser);
        await _context.SaveChangesAsync();

        return await GetCourseByIdAsync(createdCourse.Id);
    }

    public async Task<CourseDto> GetCourseByIdAsync(long id)
    {
        var course = await _context.Courses
            .FirstOrDefaultAsync(o => o.Id == id);
        if (course is null)
        {
            throw new NotFoundException(nameof(Course), id);
        }
        
        return _mapper.Map<CourseDto>(course);
    }

    public async Task<CourseDto> UpdateCourseAsync(UpdateCourseDto courseDto)
    {
        var existedCourse = await _context.Courses.FirstOrDefaultAsync(o => o.Id == courseDto.Id);
        
        if (existedCourse is null)
        {
            throw new NotFoundException(nameof(Course), courseDto.Id);
        }

        var mergedCourse = _mapper.Map(courseDto, existedCourse);

        var updatedCourse = _context.Update(mergedCourse).Entity;
        await _context.SaveChangesAsync();

        return await GetCourseByIdAsync(updatedCourse.Id);
    }

    public async Task DeleteCourseAsync(long id)
    {
        var course = await _context.Courses
            .FirstOrDefaultAsync(o => o.Id == id);
        if (course is null)
        {
            throw new NotFoundException(nameof(Course), id);
        }
        _context.Remove(course);

        await _context.SaveChangesAsync();
    }

    public async Task LeaveCourseAsync(LeaveCourseDto leaveCourseDto)
    {
        var courseUser = await _context.CourseUsers
            .FirstOrDefaultAsync(cu => cu.UserId == leaveCourseDto.UserId && cu.CourseId == leaveCourseDto.CourseId);

        if (courseUser is null)
        {
            throw new NotFoundException(nameof(CourseUser));
        }

        _context.Remove(courseUser);
        await _context.SaveChangesAsync();
    }

    public async Task<CourseDto> GetCourseByNameAsync(string courseName)
    {
        var course = await _context.Courses
            .Include(cu => cu.CourseUsers)
            .ThenInclude(u => u.User)
            .ThenInclude(a => a.Avatar)
            .FirstOrDefaultAsync(o => o.Name == courseName);

        if (course is null)
        {
            throw new NotFoundException(nameof(Course));
        }

        return _mapper.Map<CourseDto>(course);
    }

    public async Task<CourseUserDto> InviteCourseUserAsync(InviteCourseUserDto inviteCourseUserDto)
    {
        var existedCourseUser = await _context.CourseUsers
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(u => u.UserId == inviteCourseUserDto.UserId && u.CourseId == inviteCourseUserDto.CourseId);

        if (existedCourseUser is not null && !existedCourseUser.IsDeleted)
        {
            throw new InvalidOperationException($"User is already a member of course");
        }

        if(existedCourseUser is not null && existedCourseUser.IsDeleted)
        {
            existedCourseUser.IsDeleted = false;
            existedCourseUser.CourseRole = CourseRole.Member;
            existedCourseUser.CreatedAt = DateTime.UtcNow;
            var updatedCourseUser = _context.Update(existedCourseUser).Entity;
            await _context.SaveChangesAsync();
            return await GetInviteCourseUserByIdAsync(updatedCourseUser.UserId, updatedCourseUser.CourseId);

        }

        var courseUser = _mapper.Map<CourseUser>(inviteCourseUserDto, opts => opts.AfterMap((src, dst) =>
        {
            dst.CreatedAt = DateTime.Now;
        }));

        courseUser.CourseRole = CourseRole.Member;

        var invitedUser = _context.Add(courseUser).Entity;
        await _context.SaveChangesAsync();
        return await GetInviteCourseUserByIdAsync(invitedUser.UserId, invitedUser.CourseId);
    }

    public async Task<CourseUserDto> GetInviteCourseUserByIdAsync(long userId, long courseId)
    {
        var courseUser = await _context.CourseUsers.FirstOrDefaultAsync(cu => cu.UserId == userId && cu.CourseId == courseId);

        if (courseUser is null)
        {
            throw new NotFoundException(nameof(CourseUser));
        }
        return _mapper.Map<CourseUserDto>(courseUser);

    }

    public async Task<PaginatedList<CourseUserDto>> GetAllCourseUsers(long courseId, int pageNumber, int pageSize,
            Expression<Func<CourseUser, bool>>? predicate = null,
            Expression<Func<CourseUser, object>>? orderBy = null,
            SortOrder sortOrder = SortOrder.Ascending)
    {
        IQueryable<CourseUser> courseUsers = _context.CourseUsers
            .Include(u => u.User)
            .ThenInclude(a => a.Avatar)
            .AsNoTracking();

        if(predicate != null)
        {
            courseUsers = courseUsers.Where(predicate);
        }

        if(orderBy != null)
        {
            courseUsers = sortOrder == SortOrder.Descending 
                ? courseUsers.OrderByDescending(orderBy)
                : courseUsers.OrderBy(orderBy);
        }
            
        return await courseUsers
            .ProjectTo<CourseUserDto>(_mapper.ConfigurationProvider).PaginatedListAsync(pageNumber, pageSize);
    }

    public async Task<CourseUserDto> ChangeCourseUserRoleAsync(InviteCourseUserDto userRole)
    {
        var existedCourseUser = await _context.CourseUsers.FirstOrDefaultAsync(cu => cu.UserId == userRole.UserId && cu.CourseId == userRole.CourseId);

        if (existedCourseUser is null)
        {
            throw new NotFoundException(nameof(CourseUser));
        }

        var mergedCourseUser = _mapper.Map(userRole, existedCourseUser);

        var updatedCourseUser = _context.Update(mergedCourseUser).Entity;
        await _context.SaveChangesAsync();

        return await GetInviteCourseUserByIdAsync(updatedCourseUser.UserId, updatedCourseUser.CourseId);
    }
}