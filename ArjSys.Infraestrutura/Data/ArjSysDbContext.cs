using Microsoft.EntityFrameworkCore;
//using ArjSys.Dominio.Entities;

namespace ArjSys.Infraestrutura.Data;

public class ArjSysDbContext : DbContext
{
    public ArjSysDbContext(DbContextOptions<ArjSysDbContext> options) : base(options) { }

    //public DbSet<Entidade> Entidades { get; set; }  // Exemplo de uma tabela
}
