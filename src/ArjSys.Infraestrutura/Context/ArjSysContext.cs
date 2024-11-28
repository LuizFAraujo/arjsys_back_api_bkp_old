using Microsoft.EntityFrameworkCore;

namespace ArjSys.Infraestrutura.Context;

public class ArjSysContext : DbContext
{
    public ArjSysContext(DbContextOptions<ArjSysContext> options) : base(options)
    {
    }

    // Adicione DbSets para suas entidades aqui quando você criá-las
    // public DbSet<SuaEntidade> SuasEntidades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurações de mapeamento serão adicionadas aqui posteriormente
    }
}
