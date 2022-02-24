using AutoMapper;
using Codi.Core.BL.Interfaces;
using Codi.Core.BLL.Exceptions;
using Codi.Core.Common.DTO.Course;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BL.Services;

public class CourseService : BaseService, ICourseService
{
    public CourseService(CodiCoreContext context, IMapper mapper) : base(context, mapper) { }

    public async Task<ICollection<CourseDto>> GetAllCoursesAsync()
    {
        var courses = await _context.Courses.ToListAsync();
        return _mapper.Map<ICollection<CourseDto>>(courses);
    }

    public async Task<CourseDto> CreateCourseAsync(CreateCourseDto courseDto)
    {
        var existedCourse = await _context.Courses.FirstOrDefaultAsync(c => c.Name == courseDto.Name);
        if (existedCourse is not null)
        {
            throw new InvalidOperationException($"Course with name {courseDto.Name} already exists.");
        }

        var createdAt = DateTime.Now;
        var course = _mapper.Map<Course>(courseDto, opts => opts.AfterMap((src, dst) =>
        {
            dst.CreatedAt = createdAt;
        }));

        var createdCourse = _context.Add(course).Entity;
        await _context.SaveChangesAsync();
        
        var courseUser = new CourseUser()
        {
            CourseId = createdCourse.Id,
            UserId = courseDto.OwnerId,
            CourseRoleId = (await _context.CourseRoles.FirstAsync(r => r.Name == "admin")).Id,
            CreatedAt = createdAt
        };
        
        _context.Add(courseUser);
        await _context.SaveChangesAsync();

        return _mapper.Map<CourseDto>(createdCourse);
    }

    public async Task<CourseDto> GetCourseAsync(string name)
    {
        var course = await _context.Courses
            .FirstOrDefaultAsync(o => o.Name == name);
        if (course is null)
        {
            throw new NotFoundException(nameof(Course));
        }
        
        return _mapper.Map<CourseDto>(course);
    }

    public async Task<CourseDto> UpdateCourseAsync(UpdateCourseDto courseDto)
    {
        var existedCourse = await _context.Courses.FirstOrDefaultAsync(o => o.Id == courseDto.Id);
        
        if (existedCourse is null || existedCourse.OwnerId != courseDto.OwnerId)
        {
            throw new NotFoundException(nameof(Course), courseDto.Id);
        }

        var mergedCourse = _mapper.Map(courseDto, existedCourse);

        var updatedCourse = _context.Update(mergedCourse).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<CourseDto>(updatedCourse);
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
}