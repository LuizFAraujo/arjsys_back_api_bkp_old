using Microsoft.AspNetCore.Mvc;
using SYS.DOMAIN.Entities.Vendas;
using SYS.APPLICATION.Interfaces;

namespace SYS.API.Controllers;

[ApiController]
[Route("[controller]")]
public class VendasController : ControllerBase
{
    private readonly IVendaService _vendaService;

    public VendasController(IVendaService vendaService)
    {
        _vendaService = vendaService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var vendas = _vendaService.GetAll();
        return Ok(vendas);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var venda = _vendaService.GetById(id);
        if (venda == null)
        {
            return NotFound();
        }
        return Ok(venda);
    }

    [HttpPost]
    public IActionResult Post(Venda venda)
    {
        _vendaService.Add(venda);
        return CreatedAtAction(nameof(Get), new { id = venda.Id }, venda);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Venda venda)
    {
        if (id != venda.Id)
        {
            return BadRequest();
        }
        _vendaService.Update(venda);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var venda = _vendaService.GetById(id);
        if (venda == null)
        {
            return NotFound();
        }
        _vendaService.Delete(id);
        return NoContent();
    }
}
