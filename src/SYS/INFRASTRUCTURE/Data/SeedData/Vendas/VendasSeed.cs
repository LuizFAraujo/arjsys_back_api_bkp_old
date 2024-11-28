using System.Text.Json;
using SYS.DOMAIN.Entities.Vendas;
using Microsoft.EntityFrameworkCore;

namespace SYS.INFRASTRUCTURE.Data.SeedData.Vendas;

public static class VendasSeed
{
    public static void Seed(AppDbContext context)
    {
        if (!context.Vendas.Any())
        {
            var path = Path.Combine(AppContext.BaseDirectory, "INFRASTRUCTURE/Data/SeedData/Vendas/VendasSeed.json");
            var vendas = JsonSerializer.Deserialize<List<Venda>>(
                File.ReadAllText(path)
            );

            if (vendas != null)
            {
                context.Vendas.AddRange(vendas);
                context.SaveChanges();
            }
        }
    }
}
