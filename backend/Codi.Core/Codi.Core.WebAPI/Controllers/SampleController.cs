using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO;
using Codi.Core.Common.DTO.Git;
using Codi.Core.Common.DTO.Project;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        public SampleController(ISampleService sampleService, IMessageService messageService, IProjectService projectService)
        {
            _sampleService = sampleService;
            _messageService = messageService;
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<SampleDto>>> GetAllAsync()
        {
            var samples = await _sampleService.GetAllSamplesAsync();
            return Ok(samples);
        }

        [HttpGet("{sampleId}")]
        public async Task<ActionResult<SampleDto>> GetAsync(int sampleId)
        {
            var sample = await _sampleService.GetSampleAsync(sampleId);
            return Ok(sample);
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<ICollection<SampleDto>>> GetByUserAsync(int userId)
        {
            var samples = await _sampleService.GetUserSamplesAsync(userId);
            return Ok(samples);
        }

        [HttpPost]
        public async Task<ActionResult<SampleDto>> CreateAsync(NewSampleDto sampleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var sample = await _sampleService.CreateSampleAsync(sampleDto);
            return Ok(sample);
        }

        [HttpPut("{sampleId}")]
        public async Task<ActionResult<SampleDto>> UpdateAsync(int sampleId, NewSampleDto sampleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var sample = await _sampleService.UpdateSampleAsync(sampleId, sampleDto);
            return Ok(sample);
        }

        [HttpDelete("{sampleId}")]
        public async Task<ActionResult> DeleteAsync(int sampleId)
        {
            await _sampleService.DeleteSampleAsync(sampleId);
            return NoContent();
        }

        [HttpPost("/sendMessage")]
        public IActionResult SendMessage(string message)
        {
            _messageService.SendMessage(message);
            return Ok();
        }

        [HttpPost("/cloneProject")]
        public async Task<ProjectDto> CloneProject(GitCloneDto gitCloneDto)
        {
            return await _projectService.ImportProjectFromGithubAsync(gitCloneDto);
        }

        private readonly ISampleService _sampleService;
        private readonly IMessageService _messageService;
        private readonly IProjectService _projectService;
    }
}