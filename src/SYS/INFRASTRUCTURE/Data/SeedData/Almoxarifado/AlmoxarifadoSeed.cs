namespace SYS.INFRASTRUCTURE.Data.SeedData.Almoxarifado;

public static class AlmoxarifadoSeed
{
    public static void Seed(AppDbContext context)
    {
        MateriaPrimaSeed.MateriaPrimaSeed.Seed(context);
    }
}
