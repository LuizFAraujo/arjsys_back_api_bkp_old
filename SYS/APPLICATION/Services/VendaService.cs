using SYS.DOMAIN.Entities.Vendas;
using SYS.APPLICATION.Interfaces;
using SYS.DOMAIN.Interfaces;

namespace SYS.APPLICATION.Services;

public class VendaService : IVendaService
{
    private readonly IVendaRepository _vendaRepository;

    public VendaService(IVendaRepository vendaRepository)
    {
        _vendaRepository = vendaRepository;
    }

    public IEnumerable<Venda> GetAll()
    {
        return _vendaRepository.GetAll();
    }

    public Venda GetById(int id)
    {
        return _vendaRepository.GetById(id);
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
