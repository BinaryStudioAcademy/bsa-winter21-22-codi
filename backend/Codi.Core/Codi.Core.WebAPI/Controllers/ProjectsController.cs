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

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ProjectDto>>> GetAllProjects()
        {
            var projects = await _projectService.GetAllAsync();
            return Ok(projects);
        }

        [HttpGet("my/names")]
        public async Task<ActionResult<ICollection<ProjectNameDto>>> GetUserProjectNames()
        {
            var projects = await _projectService.GetUserProjectNames(this.GetUserIdFromToken());
            return Ok(projects);
        }

        [HttpGet("my")]
        public async Task<ActionResult<ICollection<ProjectDto>>> GetUserProjects()
        {
            var projects = await _projectService.GetUserProjects(this.GetUserIdFromToken());
            return Ok(projects);
        }

        [HttpGet("{projectId}")]
        public async Task<ActionResult<ICollection<ProjectDto>>> GetAllById(long projectId)
        {
            var apps = await _projectService.GetByIdAsync(projectId);
            return Ok(apps);
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
