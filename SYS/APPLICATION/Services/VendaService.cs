using SYS.DOMAIN.Entities.Vendas;
using SYS.APPLICATION.Interfaces;
using SYS.DOMAIN.Interfaces;

namespace SYS.APPLICATION.Services;

public class VendaService(IVendaRepository vendaRepository) : IVendaService
{
    private readonly IVendaRepository _vendaRepository = vendaRepository;

    public IEnumerable<Venda> GetAll()
    {
        return _vendaRepository.GetAll();
    }

    public Venda GetById(int id)
    {
        try
        {
            return _vendaRepository.GetById(id);
        }
        catch (KeyNotFoundException ex)
        {
            // Aqui você pode adicionar um log ou outra ação necessária
            throw new Exception("Venda não encontrada", ex);
        }
    }

    public void Add(Venda venda)
    {
        _vendaRepository.Add(venda);
    }

    public void Update(Venda venda)
    {
        _vendaRepository.Update(venda);
    }

    public void Delete(int id)
    {
        _vendaRepository.Delete(id);
    }
}
