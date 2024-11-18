# Configurations

Configurations é responsável por armazenar as configurações de serviços e outras integrações que são aplicadas no início da execução da aplicação. Aqui você encontrará classes que registram e configuram serviços essenciais para o funcionamento da API, como o Swagger, configurações de banco de dados, e outros middlewares.

### Função

- Registrar serviços necessários para a API, como o Swagger para documentação da API.
- Configurar integrações essenciais que a API requer durante sua execução.
- Organizar as configurações para que fiquem isoladas e centralizadas, facilitando a manutenção.

### Exemplos de Arquivos
- SwaggerConfig.cs:
--- Responsável pela configuração do Swagger (Swashbuckle), que gera a documentação interativa da API.
- DatabaseConfig.cs:
--- Arquivo que pode ser utilizado para configurar o contexto do banco de dados (por exemplo, Entity Framework).
- JwtConfig.cs:
--- Caso seja necessário configurar autenticação via JWT (JSON Web Token), este arquivo pode ser adicionado aqui.