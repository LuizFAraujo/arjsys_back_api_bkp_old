using Microsoft.AspNetCore.Mvc;
using SYS.DOMAIN.Entities.Produtos;
using SYS.INFRASTRUCTURE.Data;

namespace SYS.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var produtos = _context.Produtos.ToList();
        return Ok(produtos);
    }

    [HttpPost]
    public IActionResult Post(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
    }
}
