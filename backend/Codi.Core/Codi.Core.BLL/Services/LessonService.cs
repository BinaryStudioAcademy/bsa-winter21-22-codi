﻿using System.Linq.Expressions;
using AutoMapper;
using Codi.Core.BLL.Extentions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Lesson;
using Codi.Core.Common.DTO.Project;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using LibGit2Sharp;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BLL.Services;

public class LessonService : BaseService, ILessonService
{
    private readonly IProjectService _projectService;
    
    public LessonService(
        CodiCoreContext context,
        IMapper mapper, 
        IProjectService projectService) : base(context, mapper)
    {
        _projectService = projectService;
    }

    public async Task<ICollection<LessonDto>> GetAllByCourseAsync(long courseId, Expression<Func<Lesson, bool>>? predicate = null)
    {
        IQueryable<Lesson> lessons = _context.Lessons
            .AsNoTracking();

        if (predicate != null)
        {
            lessons = lessons.Where(predicate);
        }

        return await lessons.ProjectToListAsync<LessonDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ICollection<LessonDto>> GetAllByUnitAsync(long unitId)
    {
        return await _context.Lessons
            .Where(l => l.UnitId == unitId)
            .ProjectToListAsync<LessonDto>(_mapper.ConfigurationProvider);
    }

    public async Task<LessonDto> CreateAsync(CreateLessonDto createLessonDto)
    {
        var newProject = _mapper.Map<NewProjectDto>(createLessonDto);

        var createdProject = await _projectService.CreateAsync(newProject);
        
        var lesson = _mapper.Map<Lesson>(createLessonDto, opts => opts.AfterMap((src, dst) =>
        {
            dst.ProjectId = createdProject.Id;
            dst.CreatedAt = DateTime.Now;
        }));

        var createdLesson = _context.Add(lesson).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<LessonDto>(createdLesson);
    }

    public async Task DeleteAsync(long lessonId)
    {
        var lesson = await _context.Lessons.FirstOrDefaultAsync(l => l.Id == lessonId);

        if (lesson is null)
        {
            throw new NotFoundException(nameof(Lesson), lessonId);
        }

        _context.Remove(lesson);
        await _context.SaveChangesAsync();
    }
}