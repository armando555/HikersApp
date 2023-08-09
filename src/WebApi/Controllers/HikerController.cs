using Application.Hiker;
using Domain.Hiker;
using Domain.Hiker.Dtos;
using Domain.Hiker.Entities;
using Domain.HikerElement;
using Domain.HikerElement.Dtos;
using Domain.HikerElement.Entities;
namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class HikerController: ControllerBase
{
    private readonly IHikerProcess _hikerProcess;
    private readonly IHikerElementProcess _hikerElementProcess;
    private readonly ILogger<HikerController> _logger;
    public HikerController(ILogger<HikerController> iLogger, IHikerProcess hikerProcess, IHikerElementProcess hikerElementProcess)
    {
        _hikerProcess = hikerProcess;
        _logger = iLogger;
        _hikerElementProcess = hikerElementProcess;
    }

    [HttpGet]
    public async Task<IEnumerable<Hiker?>> Get() => await _hikerProcess.GetHikersAsync();
    
    [HttpGet("id")]
    [ProducesResponseType(typeof(Hiker), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(int id)
    {
        var hiker = await _hikerProcess.GetHikerByIdAsync(id);
        return hiker == null ? NotFound() : Ok(hiker);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(Hiker), StatusCodes.Status201Created)]
    public async Task<IActionResult> Create(HikerDto hiker)
    {
        var id = await _hikerProcess.AddHikerAsync(Hiker.FromHikerDtoToHiker(hiker));
        return CreatedAtAction(nameof(GetById), new { id}, id);
    }
    
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(Hiker), StatusCodes.Status202Accepted)]
    public async Task<IActionResult> Update(HikerUpdateDto hikerUpdateDto,int id)
    {
        var hiker = await _hikerProcess.GetHikerByIdAsync(id);
        if (hiker is null)
        {
            return NotFound();
        }
        await _hikerProcess.UpdateHikerAsync(hiker,hikerUpdateDto);
        return Ok();
    }
    
    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(Hiker), StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        await _hikerProcess.DeleteHikerASync(id);
        return NoContent();
    }

    [HttpPost("/calculate")]
    [ProducesResponseType(typeof(Hiker), StatusCodes.Status200OK)]
    //public async Task<IEnumerable<Hiker?>> CalculateHikerElements(CalculateDto calculateDto) => await _hikerProcess.GetHikersAsync();
    public async Task<IActionResult> CalculateHikerElements(CalculateDto calculateDto)
    {
        var data = await _hikerProcess.GetHikersAsync();
        return new JsonResult("esto es una gran prueba");
    }
}