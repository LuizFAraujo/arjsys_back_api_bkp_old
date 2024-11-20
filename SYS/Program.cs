using SYS.INFRASTRUCTURE.Data;

var builder = WebApplication.CreateBuilder(args);


// ===================================================================
// Adiciona os serviços ao contêiner

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(); // Adiciona o DbContext
builder.Services.AddAutoMapper(typeof(Program)); // Adiciona o AutoMapper


// Adiciona a configuração do Swagger (Documentação da API)
builder.Services.AddEndpointsApiExplorer(); // Necessário para o Swagger
builder.Services.AddSwaggerGen(); // Gera o Swagger UI







// ===================================================================

var app = builder.Build();


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
