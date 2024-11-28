using System.Text.Json;
using SYS.DOMAIN.Entities.Produtos;
using Microsoft.EntityFrameworkCore;

namespace SYS.INFRASTRUCTURE.Data.SeedData.Produtos;

public static class ProdutosSeed
{
    public static void Seed(AppDbContext context)
    {
        if (!context.Produtos.Any())
        {
            var path = Path.Combine(AppContext.BaseDirectory, "INFRASTRUCTURE/Data/SeedData/Produtos/ProdutosSeed.json");
            var produtos = JsonSerializer.Deserialize<List<Produto>>(
                File.ReadAllText(path)
            );

            if (produtos != null)
            {
                context.Produtos.AddRange(produtos);
                context.SaveChanges();
            }
        }
    }
}
