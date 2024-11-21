# Estrutura de Pastas e Arquivos

Este documento descreve a estrutura das pastas e arquivos do projeto ArjSys.
Ele fornece uma visão geral de como o código está organizado em camadas e módulos, explicando a função de cada pasta.



SYS/
├── # Dependências #
│	└── Pacotes
│		├── AutoMapper
│		├── Microsoft.EntityFrameworkCore.Sqlite
│		├── Microsoft.EntityFrameworkCore.Tools
│		└── Swashbuckle.AspNetCore
│
├── API/
│   ├── Controllers/
│   │   ├── ComprasController.cs
│   │   ├── ProdutosController.cs
│   │   └── VendasController.cs
│   └── Middlewares/
│
├── APPLICATION/
│   ├── DTOs/
│   ├── Interfaces/
│   │   ├── ICompraService.cs
│   │   ├── IProdutoService.cs
│   │   └── IVendaService.cs
│   ├── Mappers/
│   └── Services/
│       ├── CompraService.cs
│       ├── ProdutoService.cs
│       └── VendaService.cs
│
├── DOMAIN/
│   ├── Entities/
│   │   ├── Almoxarifado/
│   │   │   └── Almoxarifado.cs
│   │   ├── Compras/
│   │   │   ├── Compra.cs
│   │   │   └── ItemCompra.cs
│   │   ├── Pessoas/
│   │   │   └── Pessoa.cs
│   │   ├── Producao/
│   │   │   ├── OrdemProducao.cs
│   │   │   └── Producao.cs
│   │   ├── Produtos/
│   │   │   └── Produto.cs
│   │   ├── Shared/
│   │   │   └── BaseEntity.cs
│   │   └── Vendas/
│   │       ├── ItemVenda.cs
│   │       └── Venda.cs
│   ├── Enums/
│   ├── Exceptions/
│   ├── Interfaces/
│   │   ├── ICompraRepository.cs
│   │   ├── IProdutoRepository.cs
│   │   └── IVendaRepository.cs
│   └── Specifications/
│
├── INFRASTRUCTURE/
│   ├── Data/
│   │   ├── Configurations/
│   │   ├── Migrations/
│   │   ├── SeedData/
│   │   │   ├── Compras/
│   │   │   │   ├── ComprasSeed.cs
│   │   │   │   └── ComprasSeed.json
│   │   │   ├── Produtos/
│   │   │   │   ├── ProdutosSeed.cs
│   │   │   │   └── ProdutosSeed.json
│   │   │   ├── Vendas/
│   │   │   │   ├── VendasSeed.cs
│   │   │   │   └── VendasSeed.json
│   │   │   └── SeedDatabase.cs
│   │   └── AppDbContext.cs
│   ├── Logging/
│   └── Repositories/
│       ├── CompraRepository.cs
│       ├── ProdutoRepository.cs
│       └── VendaRepository.cs
│
├── appsettings.json
└── Program.cs

