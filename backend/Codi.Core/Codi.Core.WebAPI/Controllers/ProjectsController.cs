using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Git;
using Codi.Core.Common.DTO.Project;
using Codi.Core.WebAPI.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IUserService _userService;

        public ProjectsController(IProjectService projectService, IUserService userService)
        {
            _projectService = projectService;
            _userService = userService;

        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ProjectDto>>> GetAllProjects()
        {
            var projects = await _projectService.GetAllAsync();
            return Ok(projects);
        }

        [HttpGet("all/{userId}")]
        public async Task<ActionResult<ICollection<ProjectWithLanguageDto>>> GetUserProjectsById(long userId)
        {
            var currentUserId = await _userService.GetUserIdByFirebaseAsync(this.GetUserIdFromToken());
            if(currentUserId == userId)
            {
                return Ok(await _projectService.GetLastUserProjects(this.GetUserIdFromToken()));
            }

            return Ok(await _projectService.GetLastUserProjectsById(userId));
        }

        [HttpGet("my/names")]
        public async Task<ActionResult<ICollection<ProjectNameDto>>> GetUserProjectNames()
        {
            var projects = await _projectService.GetUserProjectNames(this.GetUserIdFromToken());
            return Ok(projects);
        }

        [HttpGet("my/last")]
        public async Task<ActionResult<ICollection<ProjectNameDto>>> GetUserLastProjects()
        {
            var projects = await _projectService.GetLastUserProjects(this.GetUserIdFromToken());
            return Ok(projects);
        }

        [HttpGet("my/gitlast")]
        public async Task<ActionResult<ICollection<ProjectNameDto>>> GetUserGitLastProjects()
        {
            var projects = await _projectService.GetLastGitUserProjects(this.GetUserIdFromToken());
            return Ok(projects);
        }

        [HttpGet("my")]
        public async Task<ActionResult<ICollection<ProjectDto>>> GetUserProjects()
        {
            var projects = await _projectService.GetUserProjects(this.GetUserIdFromToken());
            return Ok(projects);
        }

        [HttpGet("mygit")]
        public async Task<ActionResult<ICollection<ProjectDto>>> GetUserGitProjects()
        {
            var projects = await _projectService.GetUserGitProjects(this.GetUserIdFromToken());
            return Ok(projects);
        }

        [HttpGet("{projectId}")]
        public async Task<ActionResult<ProjectDto>> GetById(long projectId)
        {
            var app = await _projectService.GetByIdAsync(projectId);
            return Ok(app);
        }

        [HttpPost]
        public async Task<ActionResult<ProjectDto>> CreateAsync(NewProjectDto projectDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            projectDto.FirebaseId = this.GetUserIdFromToken();
            var project = await _projectService.CreateAsync(projectDto);
            return Ok(project);
        }

        [HttpPost("gitImport")]
        public async Task<ActionResult<ProjectDto>> GitImport(GitCloneDto gitCloneDto)
        {
            gitCloneDto.FirebaseId = this.GetUserIdFromToken();
            var project = await _projectService.ImportProjectFromGithubAsync(gitCloneDto);
            return Ok(project);
        }

        [HttpPut("{projectId}")]
        public async Task<ActionResult<ProjectDto>> UpdateAsync(long projectId, UpdateProjectDto newProjectDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var sample = await _projectService.UpdateAsync(projectId, newProjectDto);
            return Ok(sample);
        }

        [HttpDelete("{projectId}")]
        public async Task<ActionResult> DeleteAsync(int projectId)
        {
            await _projectService.DeleteAsync(projectId);
            return NoContent();
        }
    }
}
