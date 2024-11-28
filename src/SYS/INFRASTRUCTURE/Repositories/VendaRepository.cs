using SYS.DOMAIN.Entities.Vendas;
using SYS.DOMAIN.Interfaces;
using SYS.INFRASTRUCTURE.Data;

namespace SYS.INFRASTRUCTURE.Repositories;

public class VendaRepository(AppDbContext context) : IVendaRepository
{
    private readonly AppDbContext _context = context;

    public IEnumerable<Venda> GetAll()
    {
        // return _context.Vendas.ToList();
        return [.. _context.Vendas];
    }

    public Venda GetById(int id)
    {
        return _context.Vendas.Find(id) ?? throw new KeyNotFoundException("Venda não encontrada.");
    }

    public void Add(Venda venda)
    {
        _context.Vendas.Add(venda);
        _context.SaveChanges();
    }

    public void Update(Venda venda)
    {
        _context.Vendas.Update(venda);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var venda = _context.Vendas.Find(id);
        if (venda != null)
        {
            _context.Vendas.Remove(venda);
            _context.SaveChanges();
        }
    }
}
