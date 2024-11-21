using Microsoft.AspNetCore.Mvc;
using SYS.DOMAIN.Entities.Compras;
using SYS.APPLICATION.Interfaces;

namespace SYS.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ComprasController(ICompraService compraService) : ControllerBase
{
    private readonly ICompraService _compraService = compraService;

    [HttpGet]
    public IActionResult Get()
    {
        var compras = _compraService.GetAll();
        return Ok(compras);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var compra = _compraService.GetById(id);
        if (compra == null)
        {
            return NotFound();
        }
        return Ok(compra);
    }

    [HttpPost]
    public IActionResult Post(Compra compra)
    {
        _compraService.Add(compra);
        return CreatedAtAction(nameof(Get), new { id = compra.Id }, compra);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Compra compra)
    {
        if (id != compra.Id)
        {
            return BadRequest();
        }
        _compraService.Update(compra);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var compra = _compraService.GetById(id);
        if (compra == null)
        {
            return NotFound();
        }
        _compraService.Delete(id);
        return NoContent();
    }
}
