using Codi.Core.Common.DTO.Unit;

namespace Codi.Core.BLL.Interfaces;

public interface IUnitService
{
    Task<ICollection<UnitDto>> GetAllByCourseAsync(long courseId);
    Task<ICollection<UnitDto>> GetAllPublishedByCourseAsync(long courseId);
    Task<UnitDto> CreateAsync(CreateUnitDto createUnitDto);
    Task<UnitDto> UpdateAsync(UpdateUnitDto updateUnitDto);
    Task DeleteAsync(long unitId);
}