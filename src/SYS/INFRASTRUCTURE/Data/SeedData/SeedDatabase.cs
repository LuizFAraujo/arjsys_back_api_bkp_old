﻿using Microsoft.EntityFrameworkCore;
using SYS.INFRASTRUCTURE.Data.SeedData.Almoxarifado;
using SYS.INFRASTRUCTURE.Data.SeedData.Compras;
using SYS.INFRASTRUCTURE.Data.SeedData.Produtos;
using SYS.INFRASTRUCTURE.Data.SeedData.Vendas;

namespace SYS.INFRASTRUCTURE.Data.SeedData;

public static class SeedDatabase
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        AlmoxarifadoSeed.Seed(context);
        ComprasSeed.Seed(context);
        ProdutosSeed.Seed(context);
        VendasSeed.Seed(context);
    }
}