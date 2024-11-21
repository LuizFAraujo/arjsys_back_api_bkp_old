using SYS.DOMAIN.Entities.Compras;

namespace SYS.DOMAIN.Interfaces;

public interface ICompraRepository
{
    IEnumerable<Compra> GetAll();
    Compra GetById(int id);
    void Add(Compra compra);
    void Update(Compra compra);
    void Delete(int id);
}
