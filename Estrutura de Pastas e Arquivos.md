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
│   │   ├── MateriasPrimasController.cs
│   │   ├── ProdutosController.cs
│   │   └── VendasController.cs
│   └── Middlewares/
│
├── APPLICATION/
│   ├── DTOs/
│   ├── Interfaces/
│   │   ├── ICompraService.cs
│   │   ├── IMateriaPrimaService.cs
│   │   ├── IProdutoService.cs
│   │   └── IVendaService.cs
│   ├── Mappers/
│   └── Services/
│       ├── CompraService.cs
│       ├── MateriaPrimaService.cs
│       ├── ProdutoService.cs
│       └── VendaService.cs
│
├── DOMAIN/
│   ├── Entities/
│   │   ├── Almoxarifado/
│   │   │   ├── Almoxarifado.cs
│   │   │   ├── MateriaPrima.cs
│   │   │   └── MovimentacaoEstoque.cs
│   │   ├── Compras/
│   │   │   ├── Compra.cs
│   │   │   └── ItemCompra.cs
│   │   ├── Pessoas/
│   │   │   ├── Pessoa.cs
│   │   │   └── Setor.cs
│   │   ├── Producao/
│   │   │   ├── OrdemProducao.cs
│   │   │   └── Producao.cs
│   │   ├── Produtos/
│   │   │   ├── EstruturaProduto.cs
│   │   │   ├── Produto.cs
│   │   │   └── TipoProduto.cs
│   │   ├── Shared/
│   │   │   ├── AuditInfo.cs
│   │   │   └── BaseEntity.cs
│   │   └── Vendas/
│   │       ├── ItemVenda.cs
│   │       └── Venda.cs
│   ├── Enums/
│   ├── Exceptions/
│   ├── Interfaces/
│   │   ├── ICompraRepository.cs
│   │   ├── IMateriaPrimaRepository.cs
│   │   ├── IProdutoRepository.cs
│   │   └── IVendaRepository.cs
│   └── Specifications/
│
├── INFRASTRUCTURE/
│   ├── Data/
│   │   ├── Configurations/
│   │   ├── Migrations/
│   │   │   └── # Atualiza Conforme Alterações #
│   │   ├── SeedData/
│   │   │   ├── Almoxarifado/
│   │   │   │	├── MateriaPrimaSeed/
│   │   │   │   │   ├── MateriaPrimaSeed.cs
│   │   │   │   │ 	└── MateriaPrimaSeed.json
│   │   │   │   └AlmoxarifadoSeed.cs
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

