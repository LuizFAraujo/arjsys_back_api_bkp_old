using Microsoft.EntityFrameworkCore;
using ArjSys.API.Configurations;
using ArjSys.Infraestrutura.Data;

var builder = WebApplication.CreateBuilder(args);


// =================================================================
// Adiciona serviços ao contêiner

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Adiciona o AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Adiciona a configuração do Swagger
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerConfiguration();


// Configura o Entity Framework e o banco de dados
builder.Services.AddDbContext<ArjSysDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Constrói a aplicação.
var app = builder.Build();

// Configura o middleware para exibir o Swagger
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
    app.UseSwaggerConfiguration(); // Usa a configuração personalizada do Swagger
}

// =================================================================
// Configura o HTTP request pipeline.

app.UseHttpsRedirection(); // Redireciona as requisições HTTP para HTTPS
app.UseAuthorization(); // Habilita o middleware de autorização para controle de acesso às APIs
app.MapControllers(); // Mapeia os controllers da API para que as rotas sejam reconhecidas

app.Run();
