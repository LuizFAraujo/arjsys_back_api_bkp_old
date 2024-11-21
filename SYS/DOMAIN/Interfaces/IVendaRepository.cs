using SYS.DOMAIN.Entities.Vendas;

namespace SYS.DOMAIN.Interfaces;

public interface IVendaRepository
{
    IEnumerable<Venda> GetAll();
    Venda GetById(int id);
    void Add(Venda venda);
    void Update(Venda venda);
    void Delete(int id);
}
