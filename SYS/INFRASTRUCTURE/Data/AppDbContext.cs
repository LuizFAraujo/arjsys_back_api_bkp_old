using Microsoft.EntityFrameworkCore;
using SYS.DOMAIN.Entities.Almoxarifado;
using SYS.DOMAIN.Entities.Compras;
using SYS.DOMAIN.Entities.Pessoas;
using SYS.DOMAIN.Entities.Produtos;
using SYS.DOMAIN.Entities.Producao;
using SYS.DOMAIN.Entities.Vendas;

namespace SYS.INFRASTRUCTURE.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Almoxarifado> Almoxarifados { get; set; } = default!;
    public DbSet<Compra> Compras { get; set; } = default!;
    public DbSet<Pessoa> Pessoas { get; set; } = default!;
    public DbSet<Produto> Produtos { get; set; } = default!;
    public DbSet<Producao> Producoes { get; set; } = default!;
    public DbSet<OrdemProducao> OrdensProducao { get; set; } = default!;
    public DbSet<Venda> Vendas { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=arjsys.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Aplica as configurações de migração da pasta correta
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
