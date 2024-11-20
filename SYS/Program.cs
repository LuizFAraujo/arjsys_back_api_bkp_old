using SYS.APPLICATION.Interfaces;
using SYS.APPLICATION.Services;
using SYS.DOMAIN.Interfaces;
using SYS.INFRASTRUCTURE.Data;
using SYS.INFRASTRUCTURE.Repositories;

var builder = WebApplication.CreateBuilder(args);


// ===================================================================
// Adiciona os servi�os ao cont�iner

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(); // Adiciona o DbContext
builder.Services.AddAutoMapper(typeof(Program)); // Adiciona o AutoMapper


builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();



// Adiciona a configura��o do Swagger (Documenta��o da API)
builder.Services.AddEndpointsApiExplorer(); // Necess�rio para o Swagger
builder.Services.AddSwaggerGen(); // Gera o Swagger UI







// ===================================================================

var app = builder.Build();


// Configura o pipeline de requisi��es HTTP

// Habilita o Swagger apenas no ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    // Gera a documenta��o Swagger
    app.UseSwagger();

    // Configura o Swagger UI
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArjSYS API v1"));
}



app.UseHttpsRedirection();  // Redireciona para HTTPS
app.UseAuthorization();  // Habilita a autoriza��o (caso necess�rio)

app.MapControllers();  // Mapeia os controllers da API

app.Run();
