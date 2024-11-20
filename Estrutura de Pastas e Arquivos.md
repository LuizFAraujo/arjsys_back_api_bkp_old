# Estrutura de Pastas e Arquivos

Este documento descreve a estrutura das pastas e arquivos do projeto ArjSys.
Ele fornece uma visão geral de como o código está organizado em camadas e módulos, explicando a função de cada pasta.

### Função
- Ajudar na compreensão da estrutura do projeto.
- Fornecer uma referência rápida sobre onde cada parte do código está localizada.
- Facilitar a navegação e manutenção do código para desenvolvedores.




ArjSys-BackEnd
│
├── ArjSys.API/
│	├── # Dependências #
│	│	├── Pacotes
│	│	│	├── Microsoft.AspNetCore.OpenApi
│	│	│	├── Microsoft.EntityFrameworkCore
│	│	│	├── Microsoft.EntityFrameworkCore.Design
│	│	│	├── Microsoft.EntityFrameworkCore.Sqlite
│	│	│	└── Swashbuckle.AspNetCore
│	│	└── Projetos
│	│		├── ArjSys.Aplicacao
│	│		├── ArjSys.Dominio
│	│		└── ArjSys.Infraestrutura
│	├── Controllers/
│	│	├── arquivo_aqui.cs
│	│   └── _ Controllers.md
│	├── Middleware/
│	│	├── arquivo_aqui.cs
│	│   └── _ Middleware.md
│	├── appsettings.json
│	├── Program.cs
│	└── _ API.md
│	
├── ArjSys.Aplicacao/
│	├── # Dependências #
│	│	├── Pacotes
│	│	│	├── AutoMapper
│	│	│	└── FluentValidation.DependencyInjectionExtensions
│	│	└── Projetos
│	│		├── ArjSys.Dominio
│	│		└── ArjSys.Infraestrutura
│	├── DTOs/
│	│	├── arquivo_aqui.cs
│	│   └── _ DTOs.md
│	├── Interfaces/
│	│	├── arquivo_aqui.cs
│	│   └── _ Interfaces.md
│	├── Services/
│	│	├── arquivo_aqui.cs
│	│   └── _ Services.md
│	└── _ Aplicacao.md
│	
├── ArjSys.Dominio/
│	├── Entities/
│	│	├── arquivo_aqui.cs
│	│   └── _ Entities.md
│	├── Interfaces/
│	│	├── arquivo_aqui.cs
│	│   └── _ Interfaces.md
│	├── Services/
│	│	├── arquivo_aqui.cs
│	│   └── _ Services.md
│	└── _ Dominio.md
│	
├── ArjSys.Infraestrutura/
│	├── # Dependências #
│	│	├── Pacotes
│	│	│	├── Microsoft.EntityFrameworkCore
│	│	│	├── Microsoft.EntityFrameworkCore.Design
│	│	│	└── Microsoft.EntityFrameworkCore.Sqlite
│	│	└── Projetos
│	│		└── ArjSys.Dominio
│	├── Context/
│	│	├── arquivo_aqui.cs
│	│   └── _ Context.md
│	├── Mappings/
│	│	├── arquivo_aqui.cs
│	│   └── _ Mappings.md
│	├── Repositories/
│	│	├── arquivo_aqui.cs
│	│   └── _ Repositories.md
│	└── _ Infraestrutura.md
│	
├── ArjSys.Testes/
│	├── # Dependências #
│	│	├── Pacotes
│	│	│	├── Microsoft.NET.Test.Sdk
│	│	│	├── Moq
│	│	│	├── xunit
│	│	│	└── xunit.runner.visualstudio
│	│	└── Projetos
│	│		├── ArjSys.API
│	│		├── ArjSys.Aplicacao
│	│		├── ArjSys.Dominio
│	│		└── ArjSys.Infraestrutura
│	├── IntegrationTests/
│	│   └── _ IntegrationTests.md
│	├── UnitTests/
│	│   └── _ UnitTests.md
│	└── _ Testes.md
│
├── ArjSys_Api.sln
├── Estrutura de Pastas e Arquivos.md
└── README.md















ArjSys-BackEnd
│
├── ArjSys.API/
│	├── # Dependências #
│	│	├── Pacotes
│	│	└── Projetos
│	├── Controllers/
│	│	├── arquivo_aqui.cs
│	│   └── _ Controllers.md
│	├── Middleware/
│	│	├── arquivo_aqui.cs
│	│   └── _ Middleware.md
│	├── appsettings.json
│	├── Program.cs
│	└── _ API.md
│	
├── ArjSys.Aplicacao/
│	├── # Dependências #
│	│	├── Pacotes
│	│	└── Projetos
│	├── DTOs/
│	│	├── arquivo_aqui.cs
│	│   └── _ DTOs.md
│	├── Interfaces/
│	│	├── arquivo_aqui.cs
│	│   └── _ Interfaces.md
│	├── Services/
│	│	├── arquivo_aqui.cs
│	│   └── _ Services.md
│	└── _ Aplicacao.md
│	
├── ArjSys.Dominio/
│	├── Entities/
│	│	├── arquivo_aqui.cs
│	│   └── _ Entities.md
│	├── Interfaces/
│	│	├── arquivo_aqui.cs
│	│   └── _ Interfaces.md
│	├── Services/
│	│	├── arquivo_aqui.cs
│	│   └── _ Services.md
│	└── _ Dominio.md
│	
├── ArjSys.Infraestrutura/
│	├── # Dependências #
│	│	├── Pacotes
│	│	└── Projetos
│	├── Context/
│	│	├── arquivo_aqui.cs
│	│   └── _ Context.md
│	├── Mappings/
│	│	├── arquivo_aqui.cs
│	│   └── _ Mappings.md
│	├── Repositories/
│	│	├── arquivo_aqui.cs
│	│   └── _ Repositories.md
│	└── _ Infraestrutura.md
│	
├── ArjSys.Testes/
│	├── # Dependências #
│	│	├── Pacotes
│	│	└── Projetos
│	├── IntegrationTests/
│	│   └── _ IntegrationTests.md
│	├── UnitTests/
│	│   └── _ UnitTests.md
│	└── _ Testes.md
│
├── ArjSys_Api.sln
├── Estrutura de Pastas e Arquivos.md
└── README.md
