using System.Text.Json;
using SYS.DOMAIN.Entities.Almoxarifado;

namespace SYS.INFRASTRUCTURE.Data.SeedData.Almoxarifado.MateriaPrimaSeed;

public static class MateriaPrimaSeed
{
    public static void Seed(AppDbContext context)
    {
        if (!context.MateriasPrimas.Any())
        {
            var path = Path.Combine(AppContext.BaseDirectory, "INFRASTRUCTURE/Data/SeedData/Almoxarifado/MateriaPrimaSeed/MateriaPrimaSeed.json");
            var materiasPrimas = JsonSerializer.Deserialize<List<MateriaPrima>>(File.ReadAllText(path));

            if (materiasPrimas != null)
            {
                context.MateriasPrimas.AddRange(materiasPrimas);
                context.SaveChanges();
            }
        }
    }
}
