using System.Linq.Expressions;
using Codi.Core.Common.DTO.Lesson;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BLL.Interfaces;

public interface ILessonService
{
    Task<ICollection<LessonDto>> GetAllByCourseAsync(long courseId, Expression<Func<Lesson, bool>>? predicate = null);
    Task<ICollection<LessonDto>> GetAllByUnitAsync(long unitId);
    Task<LessonDto> CreateAsync(CreateLessonDto createLessonDto);
    Task DeleteAsync(long lessonId);
}