using Microsoft.AspNetCore.Mvc;
using SYS.DOMAIN.Entities.Produtos;
using SYS.APPLICATION.Interfaces;

namespace SYS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var produtos = _produtoService.GetAll();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = _produtoService.GetById(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            _produtoService.Add(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }
            _produtoService.Update(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = _produtoService.GetById(id);
            if (produto == null)
            {
                return NotFound();
            }
            _produtoService.Delete(id);
            return NoContent();
        }
    }
}
