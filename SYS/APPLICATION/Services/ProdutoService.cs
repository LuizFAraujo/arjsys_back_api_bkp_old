using SYS.DOMAIN.Entities.Produtos;
using SYS.APPLICATION.Interfaces;
using SYS.DOMAIN.Interfaces;

namespace SYS.APPLICATION.Services;

public class ProdutoService(IProdutoRepository produtoRepository) : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository = produtoRepository;

    public IEnumerable<Produto> GetAll()
    {
        return _produtoRepository.GetAll();
    }

    public Produto GetById(int id)
    {
        try
        {
            return _produtoRepository.GetById(id);
        }
        catch (KeyNotFoundException ex)
        {
            // Aqui você pode adicionar um log ou outra ação necessária
            throw new Exception("Produto não encontrado", ex);
        }
    }

    public void Add(Produto produto)
    {
        _produtoRepository.Add(produto);
    }

    public void Update(Produto produto)
    {
        _produtoRepository.Update(produto);
    }

    public void Delete(int id)
    {
        _produtoRepository.Delete(id);
    }
}
