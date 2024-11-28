using SYS.DOMAIN.Entities.Compras;
using SYS.APPLICATION.Interfaces;
using SYS.DOMAIN.Interfaces;

namespace SYS.APPLICATION.Services;

public class CompraService(ICompraRepository compraRepository) : ICompraService
{
    private readonly ICompraRepository _compraRepository = compraRepository;

    public IEnumerable<Compra> GetAll() =>
        _compraRepository.GetAll();

    public Compra GetById(int id)
    {
        try
        {
            return _compraRepository.GetById(id);
        }
        catch (KeyNotFoundException ex)
        {
            throw new Exception("Compra não encontrada", ex);
        }
    }

    public void Add(Compra compra) =>
        _compraRepository.Add(compra);

    public void Update(Compra compra) =>
        _compraRepository.Update(compra);

    public void Delete(int id) =>
        _compraRepository.Delete(id);
}
