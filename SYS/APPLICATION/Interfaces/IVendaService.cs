using SYS.DOMAIN.Entities.Vendas;

namespace SYS.APPLICATION.Interfaces;

public interface IVendaService
{
    IEnumerable<Venda> GetAll();
    Venda GetById(int id);
    void Add(Venda venda);
    void Update(Venda venda);
    void Delete(int id);
}
