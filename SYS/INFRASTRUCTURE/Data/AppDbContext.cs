using Microsoft.EntityFrameworkCore;
using SYS.DOMAIN.Entities.Almoxarifado;
using SYS.DOMAIN.Entities.Compras;
using SYS.DOMAIN.Entities.Pessoas;
using SYS.DOMAIN.Entities.Produtos;
using SYS.DOMAIN.Entities.Producao;
using SYS.DOMAIN.Entities.Vendas;

namespace SYS.INFRASTRUCTURE.Data;

public class AppDbContext : DbContext
{
    public DbSet<Almoxarifado> Almoxarifados { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Producao> Producoes { get; set; }
    public DbSet<OrdemProducao> OrdensProducao { get; set; }
    public DbSet<Venda> Vendas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=arjsys.db");
    }
}
