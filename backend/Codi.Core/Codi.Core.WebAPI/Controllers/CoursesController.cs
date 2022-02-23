using Codi.Core.BL.Interfaces;
using Codi.Core.Common.DTO.Course;
using Codi.Core.WebAPI.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class CoursesController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ICourseService _courseService;

    public CoursesController(ICourseService courseService, IUserService userService)
    {
        _courseService = courseService;
        _userService = userService;
    }

    [HttpGet("{courseName}")]
    public async Task<ActionResult<CourseDto>> GetAsync(string courseName)
    {
        var course = await _courseService.GetCourseAsync(courseName);
        return Ok(course);
    }

    [HttpPost]
    public async Task<ActionResult<CourseDto>> CreateAsync(CreateCourseDto courseDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        courseDto.OwnerId = (await _userService.GetByFirebaseId(this.GetUserIdFromToken())).Id;
        var course = await _courseService.CreateCourseAsync(courseDto);
        return Ok(course);
    }

    [HttpPut]
    public async Task<ActionResult<CourseDto>> UpdateAsync(UpdateCourseDto courseDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        courseDto.OwnerId = (await _userService.GetByFirebaseId(this.GetUserIdFromToken())).Id;
        var course = await _courseService.UpdateCourseAsync(courseDto);
        return Ok(course);
    }

    [HttpDelete("{courseId}")]
    public async Task<ActionResult> DeleteAsync(int courseId)
    {
        await _courseService.DeleteCourseAsync(courseId);
        return NoContent();
    }
}