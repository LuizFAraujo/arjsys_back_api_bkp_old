using SYS.DOMAIN.Entities.Compras;
using System.Text.Json;

namespace SYS.INFRASTRUCTURE.Data.SeedData.Compras;

public static class ComprasSeed
{
    public static void Seed(AppDbContext context)
    {
        if (!context.Compras.Any())
        {
            var path = Path.Combine(AppContext.BaseDirectory, "INFRASTRUCTURE/Data/SeedData/Compras/ComprasSeed.json");
            var compras = JsonSerializer.Deserialize<List<Compra>>(
                File.ReadAllText(path)
            );

            if (compras != null)
            {
                context.Compras.AddRange(compras);
                context.SaveChanges();
            }
        }
    }
}
