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
│	├── Controllers/
│	│   └── README - Controllers.md
│	├── DTOs/
│	│   └── README - DTOs.md
│	├── Extensions/
│	│   └── README - Extensions.md
│	├── Middleware/
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
│	│   └── README - Interfaces.md
│	├── Mappers/
│	│   └── README - Mappers.md
│	├── Services/
│	│   └── README - Services.md
│	├── Validators/
│	│   └── README - Validators.md
│	└── README - Aplicacao.md
│	
├── ArjSys.Dominio/
│	├── # Dependências #
│	│	└── Pacotes
│	│		└── FluentValidation
│	├── Entities/
│	│   └── README - Entidades.md
│	├── Interfaces/
│	│   └── README - Interfaces.md
│	├── Specifications/
│	│   └── README - Specifications.md
│	├── ValueObjects/
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
│	│   └── README - Configurations.md
│	├── Data/
│	│   └── README - Data.md
│	├── Migrations/
│	│   └── README - Migrations.md
│	├── Repositories/
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

