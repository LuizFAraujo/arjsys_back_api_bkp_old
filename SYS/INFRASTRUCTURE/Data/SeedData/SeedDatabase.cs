using System;
using global::SYS.DOMAIN.Entities.Produtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SYS.DOMAIN.Entities.Produtos;

namespace SYS.INFRASTRUCTURE.Data.SeedData;

public static class SeedDatabase
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AppDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
        {
            // Verificar se há dados na tabela Produtos
            if (context.Produtos.Any())
            {
                return;   // DB já foi populado
            }

            context.Produtos.AddRange(
                new Produto
                {
                    Codigo = "P001",
                    Descricao = "Produto 1",
                    MateriaPrima = "Materia Prima 1",
                    Ativo = true
                },
                new Produto
                {
                    Codigo = "P002",
                    Descricao = "Produto 2",
                    MateriaPrima = "Materia Prima 2",
                    Ativo = true
                }
            );

            context.SaveChanges();
        }
    }
}
