using Codi.Core.BL.Interfaces;
using Codi.Core.BLL.Models;
﻿using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Course;
using Codi.Core.Common.Enums;
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

    [HttpGet("{id}")]
    public async Task<ActionResult<CourseDto>> GetAsync(long id)
    {
        var course = await _courseService.GetCourseByIdAsync(id);
        return Ok(course);
    }

    [HttpGet("findCourse/{name}")]
    public async Task<ActionResult<CourseDto>> GetCourseByNameAsync(string name)
    {
        var course = await _courseService.GetCourseByNameAsync(name);
        return Ok(course);
    }

    [HttpPost]
    public async Task<ActionResult<CourseDto>> CreateAsync(CreateCourseDto courseDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        courseDto.OwnerId = await _userService.GetUserIdByFirebaseAsync(this.GetUserIdFromToken());
        var course = await _courseService.CreateCourseAsync(courseDto);
        return Ok(course);
    }

    [Route("invite")]
    [HttpPost]
    public async Task<ActionResult<CourseUserDto>> InviteCourseAsync(InviteCourseUserDto inviteCourseUserDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var invitedUser = await _courseService.InviteCourseUserAsync(inviteCourseUserDto);
        return Ok(invitedUser);
    }

    [HttpGet("courseUser/{courseId}")]
    public async Task<ActionResult<CourseUserDto>> GetCourseByIdAsync(int courseId)
    {
        var userId = await _userService.GetUserIdByFirebaseAsync(this.GetUserIdFromToken());
        var courseUser = await _courseService.GetInviteCourseUserByIdAsync(userId, courseId);
        return Ok(courseUser);
    }

    [HttpGet("courseUsers/{courseId}")]
    public async Task<ActionResult<PaginatedList<CourseUserDto>>> GetCourseUsersAsync(long courseId, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 5)
    {
        var userId = await _userService.GetUserIdByFirebaseAsync(this.GetUserIdFromToken());

        var courseUsers = await _courseService.GetAllCourseUsers(courseId, pageNumber, pageSize,
                orderBy: a => a.CreatedAt, sortOrder: SortOrder.Descending, predicate: cu => cu.UserId != userId && cu.CourseId == courseId);

        return Ok(courseUsers);
    }

    [Route("changeRole")]
    [HttpPut]
    public async Task<ActionResult<CourseUserDto>> UpdateCourseUser(InviteCourseUserDto userRole)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var courseUser = await _courseService.ChangeCourseUserRoleAsync(userRole);
        return Ok(courseUser);
    }

    [HttpPut]
    public async Task<ActionResult<CourseDto>> UpdateAsync(UpdateCourseDto courseDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        courseDto.OwnerId = await _userService.GetUserIdByFirebaseAsync(this.GetUserIdFromToken());
        var course = await _courseService.UpdateCourseAsync(courseDto);
        return Ok(course);
    }

    [HttpDelete("{courseId}")]
    public async Task<ActionResult> DeleteAsync(int courseId)
    {
        await _courseService.DeleteCourseAsync(courseId);
        return NoContent();
    }

    [HttpDelete("leaveCourse/{courseId}")]
    public async Task<ActionResult> LeaveAsync(int courseId)
    {
        var leaveCourseDto = new LeaveCourseDto()
        {
            CourseId = courseId,
            UserId = await _userService.GetUserIdByFirebaseAsync(this.GetUserIdFromToken())
        };
        await _courseService.LeaveCourseAsync(leaveCourseDto);
        return NoContent();
    }
    [Route("deleteUserCourse")]
    [HttpPut]
    public async Task<ActionResult> DeleteUserCourseAsync(LeaveCourseDto leaveCourseDto)
    {
        await _courseService.LeaveCourseAsync(leaveCourseDto);
        return NoContent();
    }
}
