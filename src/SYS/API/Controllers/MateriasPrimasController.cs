using Microsoft.AspNetCore.Mvc;
using SYS.APPLICATION.Interfaces;
using SYS.DOMAIN.Entities.Almoxarifado;

namespace SYS.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MateriasPrimasController(IMateriaPrimaService materiaPrimaService) : ControllerBase
{
    private readonly IMateriaPrimaService _materiaPrimaService = materiaPrimaService;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MateriaPrima>>> GetAll()
    {
        var materiasPrimas = await _materiaPrimaService.GetAllAsync();
        return Ok(materiasPrimas);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MateriaPrima>> GetById(int id)
    {
        var materiaPrima = await _materiaPrimaService.GetByIdAsync(id);
        if (materiaPrima == null) return NotFound();
        return Ok(materiaPrima);
    }

    [HttpPost]
    public async Task<ActionResult> Create(MateriaPrima materiaPrima)
    {
        await _materiaPrimaService.AddAsync(materiaPrima);
        return CreatedAtAction(nameof(GetById), new { id = materiaPrima.Id }, materiaPrima);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, MateriaPrima materiaPrima)
    {
        if (id != materiaPrima.Id) return BadRequest();
        await _materiaPrimaService.UpdateAsync(materiaPrima);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _materiaPrimaService.DeleteAsync(id);
        return NoContent();
    }
}
