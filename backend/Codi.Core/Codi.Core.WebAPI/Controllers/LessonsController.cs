using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Lesson;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class LessonsController : ControllerBase
{
    private readonly ILessonService _lessonService;

    public LessonsController(ILessonService lessonService)
    {
        _lessonService = lessonService;
    }

    [HttpGet("published/{courseId}")]
    public async Task<ActionResult<ICollection<LessonDto>>> GetPublishedCourseLessonsAsync(long courseId)
    {
        return Ok(await _lessonService.GetAllByCourseAsync(courseId, l => l.IsPublished  && l.UnitId == null));
    }

    [HttpGet("noUnit/{courseId}")]
    public async Task<ActionResult<ICollection<LessonDto>>> GetCourseLessonsWithoutUnitAsync(long courseId)
    {
        return Ok(await _lessonService.GetAllByCourseAsync(courseId, l => l.UnitId == null));
    }

    [HttpPost]
    public async Task<ActionResult<LessonDto>> CreateAsync(CreateLessonDto createLessonDto)
    {
        return Ok(await _lessonService.CreateAsync(createLessonDto));
    }

    [HttpPatch("publish/{lessonId}")]
    public async Task<ActionResult> PublishAsync(long lessonId, PublishLessonDto publishLessonDto)
    {
        await _lessonService.PublishAsync(lessonId, publishLessonDto);
        return NoContent();
    }

    [HttpDelete("{lessonId}")]
    public async Task<ActionResult> DeleteAsync(long lessonId)
    {
        await _lessonService.DeleteAsync(lessonId);
        return NoContent();
    }
}