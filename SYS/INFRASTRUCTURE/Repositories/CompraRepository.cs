using SYS.DOMAIN.Entities.Compras;
using SYS.DOMAIN.Interfaces;
using SYS.INFRASTRUCTURE.Data;

namespace SYS.INFRASTRUCTURE.Repositories;

public class CompraRepository(AppDbContext context) : ICompraRepository
{
    private readonly AppDbContext _context = context;

    public IEnumerable<Compra> GetAll() =>
        _context.Compras.ToList();

    public Compra GetById(int id) =>
        _context.Compras.Find(id) ?? throw new KeyNotFoundException("Compra não encontrada.");

    public void Add(Compra compra)
    {
        _context.Compras.Add(compra);
        _context.SaveChanges();
    }

    public void Update(Compra compra)
    {
        _context.Compras.Update(compra);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var compra = _context.Compras.Find(id);
        if (compra != null)
        {
            _context.Compras.Remove(compra);
            _context.SaveChanges();
        }
    }
}
