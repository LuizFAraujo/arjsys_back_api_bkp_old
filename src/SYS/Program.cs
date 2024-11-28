using SYS.APPLICATION.Interfaces;
using SYS.APPLICATION.Services;
using SYS.DOMAIN.Interfaces;
using SYS.INFRASTRUCTURE.Data;
using SYS.INFRASTRUCTURE.Data.SeedData;
using SYS.INFRASTRUCTURE.Repositories;

var builder = WebApplication.CreateBuilder(args);


// ===================================================================
// Adiciona os serviços ao contêiner

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(); // Adiciona o DbContext
builder.Services.AddAutoMapper(typeof(Program)); // Adiciona o AutoMapper


builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddScoped<IVendaRepository, VendaRepository>();
builder.Services.AddScoped<IVendaService, VendaService>();

builder.Services.AddScoped<ICompraRepository, CompraRepository>();
builder.Services.AddScoped<ICompraService, CompraService>();


// Adiciona a configuração do Swagger (Documentação da API)
builder.Services.AddEndpointsApiExplorer(); // Necessário para o Swagger
builder.Services.AddSwaggerGen(); // Gera o Swagger UI







// ===================================================================

var app = builder.Build();



// Chama o seed data para popular o banco de dados
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedDatabase.Initialize(services);
}


// Configura o pipeline de requisições HTTP

// Habilita o Swagger apenas no ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    // Gera a documentação Swagger
    app.UseSwagger();

    // Configura o Swagger UI
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArjSYS API v1"));
}



app.UseHttpsRedirection();  // Redireciona para HTTPS
app.UseAuthorization();  // Habilita a autorização (caso necessário)

app.MapControllers();  // Mapeia os controllers da API

app.Run();
