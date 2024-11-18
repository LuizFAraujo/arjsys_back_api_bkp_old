# Estrutura de Pastas e Arquivos

Este documento descreve a estrutura das pastas e arquivos do projeto ArjSys.
Ele fornece uma visão geral de como o código está organizado em camadas e módulos, explicando a função de cada pasta.

### Função
- Ajudar na compreensão da estrutura do projeto.
- Fornecer uma referência rápida sobre onde cada parte do código está localizada.



ArjSys-BackEnd
│
├── ArjSys.API/
│	├── # Dependências #
│	│	├── Pacotes
│	│	│	├── AutoMapper
│	│	│	├── Microsoft.EntityFrameworkCore
│	│	│	├── Microsoft.Extensions.DependencyInjection
│	│	│	└── Swashbuckle.AspNetCore
│	│	└── Projetos
│	│		├── ArjSys.Aplicacao
│	│		└── ArjSys.Infraestrutura
│	├── Configurations/
│	│	├── SwaggerConfig.cs
│	│   └── README - Configurations.md
│	├── Controllers/
│	│	├── CategoriaController.cs
│	│	├── PedidoController.cs
│	│	├── ProdutoController.cs
│	│   └── README - Controllers.md
│	├── DTOs/
│	│	├── CategoriaDTO.cs
│	│	├── CreateProdutoDTO.cs
│	│	├── PedidoDTO.cs
│	│	├── ProdutoDTO.cs
│	│   └── README - DTOs.md
│	├── Extensions/
│	│	├── MiddlewareExtensions.cs
│	│	├── ServiceCollectionExtensions.cs
│	│   └── README - Extensions.md
│	├── Middleware/
│	│	├── ExceptionHandlingMiddleware.cs
│	│	├── RequestLoggingMiddleware.cs
│	│   └── README - Middleware.md
│	├── appsettings.json
│	├── Program.cs
│	└── README - API.md
│	
├── ArjSys.Aplicacao/
│	├── # Dependências #
│	│	├── Pacotes
│	│	│	└── AutoMapper
│	│	└── Projetos
│	│		├── ArjSys.Dominio
│	│		└── ArjSys.Infraestrutura
│	├── Interfaces/
│	│	├── ICategoriaService.cs
│	│	├── IPedidoService.cs
│	│	├── IProdutoService.cs
│	│   └── README - Interfaces.md
│	├── Mappers/
│	│	├── CategoriaMapper.cs
│	│	├── PedidoMapper.cs
│	│	├── ProdutoMapper.cs
│	│   └── README - Mappers.md
│	├── Services/
│	│	├── CategoriaService.cs
│	│	├── PedidoService.cs
│	│	├── ProdutoService.cs
│	│   └── README - Services.md
│	├── Validators/
│	│	├── CategoriaValidator.cs
│	│	├── PedidoValidator.cs
│	│	├── ProdutoValidator.cs
│	│   └── README - Validators.md
│	└── README - Aplicacao.md
│	
├── ArjSys.Dominio/
│	├── # Dependências #
│	│	└── Pacotes
│	│		└── FluentValidation
│	├── Entities/
│	│	├── Categoria.cs
│	│	├── Cliente.cs
│	│	├── Pedido.cs
│	│	├── Produto.cs
│	│   └── README - Entidades.md
│	├── Interfaces/
│	│	├── ICategoriaRepository.cs
│	│	├── IPedidoRepository.cs
│	│	├── IProdutoRepository.cs
│	│   └── README - Interfaces.md
│	├── Specifications/
│	│	├── CategoriaSpecification.cs
│	│	├── PedidoSpecification.cs
│	│	├── ProdutoSpecification.cs
│	│   └── README - Specifications.md
│	├── ValueObjects/
│	│	├── Endereco.cs
│	│	├── Telefone.cs
│	│   └── README - ValueObjects.md
│	└── README - Dominio.md
│	
├── ArjSys.Infraestrutura/
│	├── # Dependências #
│	│	├── Pacotes
│	│	│	├── Microsoft.EntityFrameworkCore
│	│	│	├── Microsoft.EntityFrameworkCore.Sqlite
│	│	│	└── Microsoft.EntityFrameworkCore.Tools
│	│	└── Projetos
│	│		├── ArjSys.Aplicacao
│	│		└── ArjSys.Dominio
│	├── Configurations/
│	│	├── CategoriaConfiguration.cs
│	│	├── PedidoConfiguration.cs
│	│	├── ProdutoConfiguration.cs
│	│   └── README - Configurations.md
│	├── Data/
│	│   ├── ArjSysDbContext.cs
│	│   └── README - Data.md
│	├── Migrations/
│	│	├── AddCategoriaTable.cs
│	│	├── AddPedidoTable.cs
│	│	├── AddProdutoTable.cs
│	│   └── README - Migrations.md
│	├── Repositories/
│	│	├── CategoriaRepository.cs
│	│	├── PedidoRepository.cs
│	│	├── ProdutoRepository.cs
│	│  └── README - Repositories.md
│	└── README - Infraestrutura.md
│	
├── ArjSys.Testes/
│	├── # Dependências #
│	│	├── Pacotes
│	│	│	├── FluentAssertions
│	│	│	├── Moq
│	│	│	└── xunit
│	│	└── Projetos
│	│		├── ArjSys.API
│	│		├── ArjSys.Aplicacao
│	│		└── ArjSys.Infraestrutura
│	├── Helpers/
│	│   └── README - Helpers.md
│	├── IntegrationTests/
│	│   └── README - IntegrationTests.md
│	├── UnitTests/
│	│   └── README - UnitTests.md
│	└── README - Testes.md
│
├── ArjSys_Api.sln
├── Estrutura de Pastas e Arquivos.md
└── README.md

