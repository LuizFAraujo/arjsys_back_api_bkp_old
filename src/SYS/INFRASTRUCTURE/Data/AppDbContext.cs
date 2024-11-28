using Microsoft.EntityFrameworkCore;
using SYS.DOMAIN.Entities.Almoxarifado;
using SYS.DOMAIN.Entities.Compras;
using SYS.DOMAIN.Entities.Pessoas;
using SYS.DOMAIN.Entities.Produtos;
using SYS.DOMAIN.Entities.Producao;
using SYS.DOMAIN.Entities.Vendas;
using SYS.DOMAIN.Entities.Shared;

namespace SYS.INFRASTRUCTURE.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Almoxarifado> Almoxarifados { get; set; } = default!;
    public DbSet<MateriaPrima> MateriasPrimas { get; set; } = default!;
    public DbSet<MovimentacaoEstoque> MovimentacoesEstoque { get; set; } = default!;
    public DbSet<Compra> Compras { get; set; } = default!;
    public DbSet<Pessoa> Pessoas { get; set; } = default!;
    public DbSet<Setor> Setores { get; set; } = default!;
    public DbSet<Produto> Produtos { get; set; } = default!;
    public DbSet<EstruturaProduto> EstruturasProdutos { get; set; } = default!;
    public DbSet<TipoProduto> TiposProdutos { get; set; } = default!;
    public DbSet<Producao> Producoes { get; set; } = default!;
    public DbSet<OrdemProducao> OrdensProducao { get; set; } = default!;
    public DbSet<Venda> Vendas { get; set; } = default!;
    public DbSet<AuditInfo> Audits { get; set; } = default!;

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
