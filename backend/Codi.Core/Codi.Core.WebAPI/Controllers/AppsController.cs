using Codi.Core.BLL.Interfaces;
using Codi.Core.BLL.Models;
using Codi.Core.Common.DTO.App;
using Codi.Core.Common.Enums;
using Codi.Core.WebAPI.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class AppsController : ControllerBase
    {
        private readonly IAppService _appService;

        public AppsController(IAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedList<AppDto>>> GetAllApps([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var apps = await _appService.GetAllAsync(pageNumber, pageSize, 
                orderBy: a => a.CreatedAt, sortOrder: SortOrder.Descending);
            return Ok(apps);
        }

        [HttpGet("withTag/{tagId}")]
        public async Task<ActionResult<ICollection<AppDto>>> GetAppsWithTag(long tagId, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var apps = await _appService.GetAllWithTag(tagId, pageNumber, pageSize, 
                orderBy: a => a.CreatedAt, sortOrder: SortOrder.Descending);
            return Ok(apps);
        }

        [HttpGet("{appId}")]
        public async Task<ActionResult<AppDto>> GetById(long appId)
        {
            var app = await _appService.GetByIdAsync(appId);
            return Ok(app);
        }

        [HttpPost]
        public async Task<ActionResult<AppDto>> CreateAsync(NewAppDto appDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            appDto.FirebaseId = this.GetUserIdFromToken();
            var app = await _appService.CreateAsync(appDto);
            return Ok(app);
        }

        [HttpPut("{appId}")]
        public async Task<ActionResult<AppDto>> UpdateAsync(long appId, UpdateAppDto newAppDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var sample = await _appService.UpdateAsync(appId, newAppDto);
            return Ok(sample);
        }

        [HttpDelete("{appId}")]
        public async Task<ActionResult> DeleteAsync(int appId)
        {
            await _appService.DeleteAsync(appId);
            return NoContent();
        }
    }
}
