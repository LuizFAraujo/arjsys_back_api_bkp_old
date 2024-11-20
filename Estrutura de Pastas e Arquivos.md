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
├── API/
│   ├── Controllers/
│   │   ├── AlmoxarifadoController.cs
│   │   ├── ComprasController.cs
│   │   ├── PessoasController.cs
│   │   ├── ProducaoController.cs
│   │   ├── ProdutosController.cs
│   │   └── VendasController.cs
│   └── Middlewares/
│       └── ExceptionMiddleware.cs
├── APPLICATION/
│   ├── Dtos/
│   │   ├── AlmoxarifadoDto.cs
│   │   ├── CompraDto.cs
│   │   ├── PessoaDto.cs
│   │   ├── ProducaoDto.cs
│   │   ├── ProdutoDto.cs
│   │   └── VendaDto.cs
│   ├── Interfaces/
│   │   ├── IAlmoxarifadoService.cs
│   │   ├── ICompraService.cs
│   │   ├── IPessoaService.cs
│   │   ├── IProducaoService.cs
│   │   ├── IProdutoService.cs
│   │   └── IVendaService.cs
│   ├── Services/
│   │   ├── AlmoxarifadoService.cs
│   │   ├── CompraService.cs
│   │   ├── PessoaService.cs
│   │   ├── ProducaoService.cs
│   │   ├── ProdutoService.cs
│   │   └── VendaService.cs
│   └── Mappers/
│       └── AutoMapperProfiles.cs
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
│   │   │   ├── BaseEntity.cs
│   │   │   └── AuditInfo.cs
│   │   └── Vendas/
│   │       ├── ItemVenda.cs
│   │       └── Venda.cs
│   ├── Enums/
│   │   ├── SetorEnum.cs
│   │   ├── StatusCompraEnum.cs
│   │   └── StatusProducaoEnum.cs
│   ├── Exceptions/
│   │   ├── DomainException.cs
│   │   └── NotFoundException.cs
│   ├── Interfaces/
│   │   └── IRepository.cs
│   └── Specifications/
│       ├── ProdutoSpecification.cs
│       └── VendaSpecification.cs
├── INFRASTRUCTURE/
│   ├── Data/
│   │   ├── AppDbContext.cs
│   │   ├── Configurations/
│   │   │   ├── AlmoxarifadoConfiguration.cs
│   │   │   ├── CompraConfiguration.cs
│   │   │   ├── PessoaConfiguration.cs
│   │   │   ├── ProducaoConfiguration.cs
│   │   │   ├── ProdutoConfiguration.cs
│   │   │   └── VendaConfiguration.cs
│   │   ├── Migrations/
│   │   └── SeedData/
│   │       ├── PessoaSeed.cs
│   │       ├── ProdutoSeed.cs
│   │       └── UsuarioSeed.cs
│   ├── Logging/
│   │   └── FileLogger.cs
│   └── Repositories/
│       ├── AlmoxarifadoRepository.cs
│       ├── CompraRepository.cs
│       ├── PessoaRepository.cs
│       ├── ProducaoRepository.cs
│       ├── ProdutoRepository.cs
│       └── VendaRepository.cs
├── Tests/
│   ├── UnitTests/
│   │   ├── Services/
│   │   └── Repositories/
│   └── IntegrationTests/
│       ├── Controllers/
│       └── Endpoints/
├── appsettings.json
└── Program.cs









├── appsettings.Development.json


SYS/
├── # Dependências #
│	└── Pacotes
│		├── AutoMapper
│		├── Microsoft.EntityFrameworkCore.Sqlite
│		├── Microsoft.EntityFrameworkCore.Tools
│		└── Swashbuckle.AspNetCore
├── API/
│   ├── Controllers/
│   │   ├── ProdutosController.cs
├── APPLICATION/
├── DOMAIN/
│   ├── Entities/
│   │   ├── Almoxarifado/
│   │   ├── Compras/
│   │   ├── Pessoas/
│   │   ├── Producao/
│   │   ├── Produtos/
│   │   │   ├── Produto.cs
│   │   ├── Shared/
│   │   └── Vendas/
│   │       ├── ItemVenda.cs
│   │       └── Venda.cs
├── INFRASTRUCTURE/
│   ├── Data/
│   │   ├── AppDbContext.cs
├── appsettings.json
└── Program.cs













