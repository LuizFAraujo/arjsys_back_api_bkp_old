using SYS.DOMAIN.Entities.Compras;

namespace SYS.APPLICATION.Interfaces;

public interface ICompraService
{
    IEnumerable<Compra> GetAll();
    Compra GetById(int id);
    void Add(Compra compra);
    void Update(Compra compra);
    void Delete(int id);
}
