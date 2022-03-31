using AutoMapper;
using Codi.Core.BLL.Exceptions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Unit;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BLL.Services;

public class UnitService : BaseService, IUnitService
{
    public UnitService(CodiCoreContext context, IMapper mapper) : base(context, mapper) { }

    public async Task<ICollection<UnitDto>> GetAllByCourseAsync(long courseId)
    {
        var units = await _context.Units
            .Include(u => u.Lessons)
            .Where(u => u.CourseId == courseId)
            .ToListAsync();

        return _mapper.Map<ICollection<UnitDto>>(units);
    }
    
    public async Task<ICollection<UnitDto>> GetAllPublishedByCourseAsync(long courseId)
    {
        var units = await _context.Units
            .Include(u => u.Lessons.Where(l => l.IsPublished))
            .Where(u => u.CourseId == courseId && u.Lessons.Any(l => l.IsPublished))
            .ToListAsync();

        return _mapper.Map<ICollection<UnitDto>>(units);
    }

    public async Task<UnitDto> CreateAsync(CreateUnitDto createUnitDto)
    {
        var unit = _mapper.Map<Unit>(createUnitDto, opts => opts.AfterMap((src, dst) =>
        {
            dst.CreatedAt = DateTime.Now;
        }));

        var createdUnit = _context.Add(unit).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<UnitDto>(createdUnit);
    }

    public async Task<UnitDto> UpdateAsync(UpdateUnitDto updateUnitDto)
    {
        var existedUnit = await _context.Units
            .FirstOrDefaultAsync(u => u.Id == updateUnitDto.Id);

        if (existedUnit is null)
        {
            throw new NotFoundException(nameof(Unit), updateUnitDto.Id);
        }

        var mergedUnit = _mapper.Map(updateUnitDto, existedUnit);

        var updatedUnit = _context.Update(mergedUnit).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<UnitDto>(updatedUnit);
    }

    public async Task DeleteAsync(long unitId)
    {
        var unit = await _context.Units
            .Include(U => U.Lessons)
            .FirstOrDefaultAsync(u => u.Id == unitId);
        
        if (unit is null)
        {
            throw new NotFoundException(nameof(Unit), unitId);
        }
        
        _context.RemoveRange(unit.Lessons);
        _context.Remove(unit);

        await _context.SaveChangesAsync();
    }
}