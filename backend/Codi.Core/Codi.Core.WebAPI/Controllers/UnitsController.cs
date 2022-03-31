using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Unit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class UnitsController : ControllerBase
{
    private readonly IUnitService _unitService;

    public UnitsController(IUnitService unitService)
    {
        _unitService = unitService;
    }

    [HttpGet("{courseId}")]
    public async Task<ActionResult<ICollection<UnitDto>>> GetAllByCourseAsync(long courseId)
    {
        var units = await _unitService.GetAllByCourseAsync(courseId);
        return Ok(units);
    }

    [HttpPost]
    public async Task<ActionResult<UnitDto>> CreateAsync(CreateUnitDto unitDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        var unit = await _unitService.CreateAsync(unitDto);
        return Ok(unit);
    }

    [HttpPut]
    public async Task<ActionResult<UnitDto>> UpdateAsync(UpdateUnitDto unitDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        var unit = await _unitService.UpdateAsync(unitDto);
        return Ok(unit);
    }
    
    [HttpDelete("{unitId}")]
    public async Task<ActionResult> DeleteAsync(long unitId)
    {
        await _unitService.DeleteAsync(unitId);
        return NoContent();
    }
}